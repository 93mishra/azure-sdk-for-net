﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The predicted sentiment and other analysis like Assessment mining
    /// for each sentence in the corresponding document.
    /// <para>For more information regarding text sentiment, see
    /// <a href="https://docs.microsoft.com/azure/cognitive-services/Text-Analytics/how-tos/text-analytics-how-to-sentiment-analysis"/>.</para>
    /// </summary>
    public readonly struct SentenceSentiment
    {
        internal SentenceSentiment(TextSentiment sentiment, string text, double positiveScore, double neutralScore, double negativeScore, int offset, int length, IReadOnlyList<MinedAssessment> minedAssessments)
        {
            Sentiment = sentiment;
            Text = text;
            ConfidenceScores = new SentimentConfidenceScores(positiveScore, neutralScore, negativeScore);
            Offset = offset;
            Length = length;
            MinedAssessments = new List<MinedAssessment>(minedAssessments);
        }

        internal SentenceSentiment(SentenceSentimentInternal sentenceSentiment, IReadOnlyList<SentenceSentimentInternal> allSentences)
        {
            // We shipped TA 5.0.0 Text == string.Empty if the service returned a null value for Text.
            // Because we don't want to introduce a breaking change, we are transforming that null to string.Empty
            Text = sentenceSentiment.Text ?? string.Empty;

            ConfidenceScores = sentenceSentiment.ConfidenceScores;
            Sentiment = (TextSentiment)Enum.Parse(typeof(TextSentiment), sentenceSentiment.Sentiment, ignoreCase: true);
            MinedAssessments = ConvertToMinedAssessments(sentenceSentiment, allSentences);
            Offset = sentenceSentiment.Offset;
            Length = sentenceSentiment.Length;
        }

        /// <summary>
        /// Gets the predicted sentiment for the analyzed sentence.
        /// </summary>
        public TextSentiment Sentiment { get; }

        /// <summary>
        /// Gets the sentence text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the sentiment confidence score (Softmax score) between 0 and 1,
        /// for each sentiment. Higher values signify higher confidence.
        /// </summary>
        public SentimentConfidenceScores ConfidenceScores { get; }

        /// <summary>
        /// Gets the mined assessment of a sentence. This is only returned if
        /// <see cref="AnalyzeSentimentOptions.IncludeAssessmentMining"/> is set to True.
        /// </summary>
        public IReadOnlyCollection<MinedAssessment> MinedAssessments { get; }

        /// <summary>
        /// Gets the starting position for the matching text in the sentence.
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// Gets the length the matching text in the sentence.
        /// </summary>
        public int Length { get; }

        private static IReadOnlyCollection<MinedAssessment> ConvertToMinedAssessments(SentenceSentimentInternal sentence, IReadOnlyList<SentenceSentimentInternal> allSentences)
        {
            var minedAssessments = new List<MinedAssessment>();

            foreach (SentenceTarget target in sentence.Targets)
            {
                var assessment = new List<AssessmentSentiment>();
                foreach (TargetRelation relation in target.Relations)
                {
                    if (relation.RelationType == TargetRelationType.Assessment)
                    {
                        assessment.Add(ResolveAssessmentReference(allSentences, relation.Ref));
                    }
                }
                minedAssessments.Add(new MinedAssessment(new TargetSentiment(target), assessment));
            }

            return minedAssessments;
        }

        private static Regex _assessmentRegex = new Regex(@"/documents/(?<documentIndex>\d*)/sentences/(?<sentenceIndex>\d*)/assessments/(?<assessmentIndex>\d*)$", RegexOptions.Compiled, TimeSpan.FromSeconds(2));
        internal static AssessmentSentiment ResolveAssessmentReference(IReadOnlyList<SentenceSentimentInternal> sentences, string reference)
        {
            // Example: the following should result in sentenceIndex = 2, assessmentIndex = 1. There will not be cases where sentences from other documents are referenced.
            // "#/documents/0/sentences/2/assessments/1"

            var assessmentMatch = _assessmentRegex.Match(reference);
            if (assessmentMatch.Success && assessmentMatch.Groups.Count == 4)
            {
                int sentenceIndex = int.Parse(assessmentMatch.Groups["sentenceIndex"].Value, CultureInfo.InvariantCulture);
                int assessmentIndex = int.Parse(assessmentMatch.Groups["assessmentIndex"].Value, CultureInfo.InvariantCulture);

                if (sentenceIndex < sentences.Count)
                {
                    if (assessmentIndex < sentences[sentenceIndex].Assessments.Count)
                    {
                        return new AssessmentSentiment(sentences[sentenceIndex].Assessments[assessmentIndex]);
                    }
                }
            }

            throw new InvalidOperationException($"Failed to parse element reference: {reference}");
        }
    }
}
