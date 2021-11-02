// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Describes a set of label selectors that will be attached if the given condition resolves to true. </summary>
    public partial class ConditionalLabelSelector : LabelSelectorAttachment
    {
        /// <summary> Initializes a new instance of ConditionalLabelSelector. </summary>
        /// <param name="condition"> The condition that must be true for the label selectors to be attached. </param>
        /// <param name="labelSelectors"> The label selectors to attach. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="condition"/> or <paramref name="labelSelectors"/> is null. </exception>
        public ConditionalLabelSelector(RouterRule condition, IEnumerable<LabelSelector> labelSelectors)
        {
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }
            if (labelSelectors == null)
            {
                throw new ArgumentNullException(nameof(labelSelectors));
            }

            Condition = condition;
            LabelSelectors = labelSelectors.ToList();
            Kind = "conditional";
        }

        /// <summary> Initializes a new instance of ConditionalLabelSelector. </summary>
        /// <param name="kind"> The type discriminator describing the type of label selector attachment. </param>
        /// <param name="condition"> The condition that must be true for the label selectors to be attached. </param>
        /// <param name="labelSelectors"> The label selectors to attach. </param>
        internal ConditionalLabelSelector(string kind, RouterRule condition, IList<LabelSelector> labelSelectors) : base(kind)
        {
            Condition = condition;
            LabelSelectors = labelSelectors;
            Kind = kind ?? "conditional";
        }

        /// <summary> The condition that must be true for the label selectors to be attached. </summary>
        public RouterRule Condition { get; set; }
        /// <summary> The label selectors to attach. </summary>
        public IList<LabelSelector> LabelSelectors { get; }
    }
}
