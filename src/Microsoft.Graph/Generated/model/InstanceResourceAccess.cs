// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type InstanceResourceAccess.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InstanceResourceAccess>))]
    public partial class InstanceResourceAccess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceResourceAccess"/> class.
        /// </summary>
        public InstanceResourceAccess()
        {
        }

        /// <summary>
        /// Gets or sets permissions.
        /// </summary>
        [JsonPropertyName("permissions")]
        public IEnumerable<ResourcePermission> Permissions { get; set; }
    
        /// <summary>
        /// Gets or sets resourceAppId.
        /// </summary>
        [JsonPropertyName("resourceAppId")]
        public string ResourceAppId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
