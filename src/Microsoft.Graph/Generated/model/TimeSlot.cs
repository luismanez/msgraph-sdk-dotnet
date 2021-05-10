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
    /// The type TimeSlot.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TimeSlot>))]
    public partial class TimeSlot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlot"/> class.
        /// </summary>
        public TimeSlot()
        {
        }

        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that a period begins.
        /// </summary>
        [JsonPropertyName("end")]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that a period ends.
        /// </summary>
        [JsonPropertyName("start")]
        public DateTimeTimeZone Start { get; set; }
    
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
