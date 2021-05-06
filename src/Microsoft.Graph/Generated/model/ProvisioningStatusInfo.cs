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
    /// The type ProvisioningStatusInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ProvisioningStatusInfo>))]
    public partial class ProvisioningStatusInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningStatusInfo"/> class.
        /// </summary>
        public ProvisioningStatusInfo()
        {
        }

        /// <summary>
        /// Gets or sets errorInformation.
        /// </summary>
        [JsonPropertyName("errorInformation")]
        public ProvisioningErrorInfo ErrorInformation { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public ProvisioningResult? Status { get; set; }
    
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