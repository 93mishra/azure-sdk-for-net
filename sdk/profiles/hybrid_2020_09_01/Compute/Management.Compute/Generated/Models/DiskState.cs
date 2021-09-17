// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{

    /// <summary>
    /// Defines values for DiskState.
    /// </summary>
    public static class DiskState
    {
        /// <summary>
        /// The disk is not being used and can be attached to a VM.
        /// </summary>
        public const string Unattached = "Unattached";
        /// <summary>
        /// The disk is currently mounted to a running VM.
        /// </summary>
        public const string Attached = "Attached";
        /// <summary>
        /// The disk is mounted to a stopped-deallocated VM
        /// </summary>
        public const string Reserved = "Reserved";
        /// <summary>
        /// The disk currently has an Active SAS Uri associated with it.
        /// </summary>
        public const string ActiveSAS = "ActiveSAS";
        /// <summary>
        /// A disk is ready to be created by upload by requesting a write
        /// token.
        /// </summary>
        public const string ReadyToUpload = "ReadyToUpload";
        /// <summary>
        /// A disk is created for upload and a write token has been issued for
        /// uploading to it.
        /// </summary>
        public const string ActiveUpload = "ActiveUpload";
    }
}
