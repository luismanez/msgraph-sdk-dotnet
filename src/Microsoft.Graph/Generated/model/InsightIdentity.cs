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
    /// The type InsightIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InsightIdentity>))]
    public partial class InsightIdentity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightIdentity"/> class.
        /// </summary>
        public InsightIdentity()
        {
        }

        /// <summary>
        /// Gets or sets address.
        /// The email address of the user who shared the item.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the user who shared the item.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// The id of the user who shared the item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
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
