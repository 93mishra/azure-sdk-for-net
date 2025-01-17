// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// SSIS object metadata.
    /// Please note <see cref="SynapseSsisObjectMetadata"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseSsisEnvironment"/>, <see cref="SynapseSsisFolder"/>, <see cref="SynapseSsisPackage"/> and <see cref="SynapseSsisProject"/>.
    /// </summary>
    public abstract partial class SynapseSsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SynapseSsisObjectMetadata. </summary>
        protected SynapseSsisObjectMetadata()
        {
        }

        /// <summary> Initializes a new instance of SynapseSsisObjectMetadata. </summary>
        /// <param name="metadataType"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        internal SynapseSsisObjectMetadata(SynapseSsisObjectMetadataType metadataType, long? id, string name, string description)
        {
            MetadataType = metadataType;
            Id = id;
            Name = name;
            Description = description;
        }

        /// <summary> Type of metadata. </summary>
        internal SynapseSsisObjectMetadataType MetadataType { get; set; }
        /// <summary> Metadata id. </summary>
        public long? Id { get; }
        /// <summary> Metadata name. </summary>
        public string Name { get; }
        /// <summary> Metadata description. </summary>
        public string Description { get; }
    }
}
