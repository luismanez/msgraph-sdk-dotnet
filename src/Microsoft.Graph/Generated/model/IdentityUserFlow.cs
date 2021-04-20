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
    /// The type Identity User Flow.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IdentityUserFlow : Entity
    {
    
		///<summary>
		/// The IdentityUserFlow constructor
		///</summary>
        public IdentityUserFlow()
        {
            this.ODataType = "microsoft.graph.identityUserFlow";
        }
	
        /// <summary>
        /// Gets or sets user flow type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userFlowType", Required = Newtonsoft.Json.Required.Default)]
        public UserFlowType? UserFlowType { get; set; }
    
        /// <summary>
        /// Gets or sets user flow type version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userFlowTypeVersion", Required = Newtonsoft.Json.Required.Default)]
        public Single? UserFlowTypeVersion { get; set; }
    
    }
}

