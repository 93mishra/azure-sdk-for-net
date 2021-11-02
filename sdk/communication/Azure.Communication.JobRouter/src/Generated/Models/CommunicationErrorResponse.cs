// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> The CommunicationErrorResponse. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Initializes a new instance of CommunicationErrorResponse. </summary>
        /// <param name="communicationError"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationError"/> is null. </exception>
        internal CommunicationErrorResponse(CommunicationError communicationError)
        {
            if (communicationError == null)
            {
                throw new ArgumentNullException(nameof(communicationError));
            }

            CommunicationError = communicationError;
        }

        public CommunicationError CommunicationError { get; }
    }
}
