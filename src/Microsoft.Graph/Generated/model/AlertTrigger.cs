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
    /// The type AlertTrigger.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AlertTrigger>))]
    public partial class AlertTrigger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTrigger"/> class.
        /// </summary>
        public AlertTrigger()
        {
        }

        /// <summary>
        /// Gets or sets name.
        /// Name of the property serving as a detection trigger.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Type of the property in the key:value pair for interpretation. For example, String, Boolean, etc.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Value of the property serving as a detection trigger.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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
