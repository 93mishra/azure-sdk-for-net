// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for create call. </summary>
    internal partial class CreateCallRequestInternal
    {
        /// <summary> Initializes a new instance of CreateCallRequestInternal. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/>, <paramref name="source"/>, or <paramref name="callbackUri"/> is null. </exception>
        public CreateCallRequestInternal(IEnumerable<CommunicationIdentifierModel> targets, CommunicationIdentifierModel source, string callbackUri)
        {
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            Targets = targets.ToList();
            Source = source;
            CallbackUri = callbackUri;
            RequestedMediaTypes = new ChangeTrackingList<CallMediaType>();
            RequestedCallEvents = new ChangeTrackingList<CallingEventSubscriptionType>();
        }

        /// <summary> The alternate identity of the source of the call if dialing out to a pstn number. </summary>
        public PhoneNumberIdentifierModel AlternateCallerId { get; set; }
        /// <summary> The targets of the call. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The source of the call. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The subject. </summary>
        public string Subject { get; set; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> The requested modalities. </summary>
        public IList<CallMediaType> RequestedMediaTypes { get; }
        /// <summary> The requested call events to subscribe to. </summary>
        public IList<CallingEventSubscriptionType> RequestedCallEvents { get; }
    }
}
