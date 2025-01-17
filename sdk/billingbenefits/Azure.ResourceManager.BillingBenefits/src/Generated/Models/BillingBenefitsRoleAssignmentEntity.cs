// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> Role assignment entity. </summary>
    public partial class BillingBenefitsRoleAssignmentEntity
    {
        /// <summary> Initializes a new instance of BillingBenefitsRoleAssignmentEntity. </summary>
        internal BillingBenefitsRoleAssignmentEntity()
        {
        }

        /// <summary> Initializes a new instance of BillingBenefitsRoleAssignmentEntity. </summary>
        /// <param name="id"> Role assignment entity id. </param>
        /// <param name="name"> Role assignment entity name. </param>
        /// <param name="principalId"> Principal Id. </param>
        /// <param name="roleDefinitionId"> Role definition id. </param>
        /// <param name="scope"> Scope of the role assignment entity. </param>
        internal BillingBenefitsRoleAssignmentEntity(ResourceIdentifier id, string name, string principalId, ResourceIdentifier roleDefinitionId, ResourceIdentifier scope)
        {
            Id = id;
            Name = name;
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
        }

        /// <summary> Role assignment entity id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Role assignment entity name. </summary>
        public string Name { get; }
        /// <summary> Principal Id. </summary>
        public string PrincipalId { get; }
        /// <summary> Role definition id. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> Scope of the role assignment entity. </summary>
        public ResourceIdentifier Scope { get; }
    }
}
