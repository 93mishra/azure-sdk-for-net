// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for holding meeting audio for a participant. </summary>
    internal partial class HoldMeetingAudioRequest
    {
        /// <summary> Initializes a new instance of HoldMeetingAudioRequest. </summary>
        /// <param name="identifier"> The identifier of the participant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        public HoldMeetingAudioRequest(CommunicationIdentifierModel identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }

            Identifier = identifier;
        }

        /// <summary> The identifier of the participant. </summary>
        public CommunicationIdentifierModel Identifier { get; }
    }
}
