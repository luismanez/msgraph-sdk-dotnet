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
    /// The type SamlSingleSignOnSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SamlSingleSignOnSettings>))]
    public partial class SamlSingleSignOnSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamlSingleSignOnSettings"/> class.
        /// </summary>
        public SamlSingleSignOnSettings()
        {
        }

        /// <summary>
        /// Gets or sets relayState.
        /// The relative URI the service provider would redirect to after completion of the single sign-on flow.
        /// </summary>
        [JsonPropertyName("relayState")]
        public string RelayState { get; set; }
    
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
