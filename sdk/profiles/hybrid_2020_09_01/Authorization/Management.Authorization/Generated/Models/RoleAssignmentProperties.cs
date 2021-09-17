// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Authorization.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role assignment properties.
    /// </summary>
    public partial class RoleAssignmentProperties
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignmentProperties class.
        /// </summary>
        public RoleAssignmentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignmentProperties class.
        /// </summary>
        /// <param name="roleDefinitionId">The role definition ID used in the
        /// role assignment.</param>
        /// <param name="principalId">The principal ID assigned to the role.
        /// This maps to the ID inside the Active Directory. It can point to a
        /// user, service principal, or security group.</param>
        public RoleAssignmentProperties(string roleDefinitionId, string principalId)
        {
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role definition ID used in the role assignment.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the principal ID assigned to the role. This maps to
        /// the ID inside the Active Directory. It can point to a user, service
        /// principal, or security group.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleDefinitionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleDefinitionId");
            }
            if (PrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrincipalId");
            }
        }
    }
}
