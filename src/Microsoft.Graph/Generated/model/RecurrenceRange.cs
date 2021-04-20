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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type RecurrenceRange.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RecurrenceRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRange"/> class.
        /// </summary>
        public RecurrenceRange()
        {
            this.ODataType = "microsoft.graph.recurrenceRange";
        }

        /// <summary>
        /// Gets or sets endDate.
        /// The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDate", Required = Newtonsoft.Json.Required.Default)]
        public Date EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets numberOfOccurrences.
        /// The number of times to repeat the event. Required and must be positive if type is numbered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberOfOccurrences", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NumberOfOccurrences { get; set; }
    
        /// <summary>
        /// Gets or sets recurrenceTimeZone.
        /// Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurrenceTimeZone", Required = Newtonsoft.Json.Required.Default)]
        public string RecurrenceTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets startDate.
        /// The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDate", Required = Newtonsoft.Json.Required.Default)]
        public Date StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The recurrence range. Possible values are: endDate, noEnd, numbered. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public RecurrenceRangeType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
