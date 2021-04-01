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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Unified Role Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnifiedRoleAssignment : Entity
    {
    
		///<summary>
		/// The UnifiedRoleAssignment constructor
		///</summary>
        public UnifiedRoleAssignment()
        {
            this.ODataType = "microsoft.graph.unifiedRoleAssignment";
        }
	
        /// <summary>
        /// Gets or sets app scope id.
        /// Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appScopeId", Required = Newtonsoft.Json.Required.Default)]
        public string AppScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets condition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "condition", Required = Newtonsoft.Json.Required.Default)]
        public string Condition { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope id.
        /// Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directoryScopeId", Required = Newtonsoft.Json.Required.Default)]
        public string DirectoryScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// Objectid of the principal to which the assignment is granted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalId", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// ID of the unifiedRoleDefinition the assignment is for. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitionId", Required = Newtonsoft.Json.Required.Default)]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets app scope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appScope", Required = Newtonsoft.Json.Required.Default)]
        public AppScope AppScope { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directoryScope", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject DirectoryScope { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principal", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject Principal { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinition", Required = Newtonsoft.Json.Required.Default)]
        public UnifiedRoleDefinition RoleDefinition { get; set; }
    
    }
}

