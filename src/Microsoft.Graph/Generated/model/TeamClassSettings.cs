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
    /// The type TeamClassSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamClassSettings>))]
    public partial class TeamClassSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamClassSettings"/> class.
        /// </summary>
        public TeamClassSettings()
        {
        }

        /// <summary>
        /// Gets or sets notifyGuardiansAboutAssignments.
        /// If set to true, enables sending of weekly assignments digest emails to parents/guardians, provided the tenant admin has enabled the setting globally.
        /// </summary>
        [JsonPropertyName("notifyGuardiansAboutAssignments")]
        public bool? NotifyGuardiansAboutAssignments { get; set; }
    
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
