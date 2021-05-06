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
    /// The type SettingTemplateValue.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SettingTemplateValue>))]
    public partial class SettingTemplateValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingTemplateValue"/> class.
        /// </summary>
        public SettingTemplateValue()
        {
        }

        /// <summary>
        /// Gets or sets defaultValue.
        /// Default value for the setting. Read-only.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the setting. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the setting. Read-only.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Type of the setting. Read-only.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
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
