// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The transfer call result event. </summary>
    internal partial class TransferCallResultEvent
    {
        /// <summary> Initializes a new instance of TransferCallResultEvent. </summary>
        /// <param name="status"> The status of the operation. </param>
        internal TransferCallResultEvent(CallingOperationStatus status)
        {
            Status = status;
        }

        /// <summary> The result details. </summary>
        public CallingOperationResultDetails ResultInfo { get; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; }
        /// <summary> The status of the operation. </summary>
        public CallingOperationStatus Status { get; }
    }
}
