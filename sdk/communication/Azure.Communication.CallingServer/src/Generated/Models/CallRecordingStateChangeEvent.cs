// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> The call recording state change event. </summary>
    public partial class CallRecordingStateChangeEvent
    {
        /// <summary> Initializes a new instance of CallRecordingStateChangeEvent. </summary>
        /// <param name="callRecordingState"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        internal CallRecordingStateChangeEvent(CallRecordingState callRecordingState, DateTimeOffset startDateTime)
        {
            CallRecordingState = callRecordingState;
            StartDateTime = startDateTime;
        }

        /// <summary> Initializes a new instance of CallRecordingStateChangeEvent. </summary>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="callRecordingState"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        /// <param name="callLocator"> The server call locator. </param>
        internal CallRecordingStateChangeEvent(string recordingId, CallRecordingState callRecordingState, DateTimeOffset startDateTime, CallLocatorModel callLocator)
        {
            RecordingId = recordingId;
            CallRecordingState = callRecordingState;
            StartDateTime = startDateTime;
            CallLocator = callLocator;
        }

        /// <summary> The call recording id. </summary>
        public string RecordingId { get; }
        /// <summary> The state of the recording. </summary>
        public CallRecordingState CallRecordingState { get; }
        /// <summary> The time of the recording started. </summary>
        public DateTimeOffset StartDateTime { get; }
        /// <summary> The server call locator. </summary>
        public CallLocatorModel CallLocator { get; }
    }
}
