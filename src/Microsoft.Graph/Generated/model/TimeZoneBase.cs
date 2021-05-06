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
    /// The type TimeZoneBase.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TimeZoneBase>))]
    public partial class TimeZoneBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeZoneBase"/> class.
        /// </summary>
        public TimeZoneBase()
        {
        }

        /// <summary>
        /// Gets or sets name.
        /// The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
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
