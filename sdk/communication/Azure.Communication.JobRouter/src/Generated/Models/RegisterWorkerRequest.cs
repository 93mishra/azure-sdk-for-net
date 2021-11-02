// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Request payload for registering workers. </summary>
    internal partial class RegisterWorkerRequest
    {
        /// <summary> Initializes a new instance of RegisterWorkerRequest. </summary>
        /// <param name="id"> Unique key that identifies this worker. </param>
        /// <param name="totalCapacity"> Total score that can be consumed by offers and assignments under this worker. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public RegisterWorkerRequest(string id, int totalCapacity)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            QueueAssignments = new ChangeTrackingList<QueueAssignment>();
            TotalCapacity = totalCapacity;
            _labels = new ChangeTrackingDictionary<string, object>();
            ChannelConfigurations = new ChangeTrackingList<ChannelConfiguration>();
        }

        /// <summary> Unique key that identifies this worker. </summary>
        public string Id { get; }
        /// <summary> The queues assignments for this worker. </summary>
        public IList<QueueAssignment> QueueAssignments { get; set; }
        /// <summary> Total score that can be consumed by offers and assignments under this worker. </summary>
        public int TotalCapacity { get; }
    }
}
