// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Delegated Permission Classification.
    /// </summary>
    public partial class DelegatedPermissionClassification : Entity
    {
    
        ///<summary>
        /// The DelegatedPermissionClassification constructor
        ///</summary>
        public DelegatedPermissionClassification()
        {
        }

        /// <summary>
        /// Gets or sets classification.
        /// The classification value being given. Possible value: low. Does not support $filter.
        /// </summary>
        [JsonPropertyName("classification")]
        public PermissionClassificationType? Classification { get; set; }
    
        /// <summary>
        /// Gets or sets permission id.
        /// The unique identifier (id) for the delegated permission listed in the oauth2PermissionScopes collection of the servicePrincipal. Required on create. Does not support $filter.
        /// </summary>
        [JsonPropertyName("permissionId")]
        public string PermissionId { get; set; }
    
        /// <summary>
        /// Gets or sets permission name.
        /// The claim value (value) for the delegated permission listed in the oauth2PermissionScopes collection of the servicePrincipal. Does not support $filter.
        /// </summary>
        [JsonPropertyName("permissionName")]
        public string PermissionName { get; set; }
    
    }
}

