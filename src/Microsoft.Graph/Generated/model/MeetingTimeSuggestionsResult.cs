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
    /// The type MeetingTimeSuggestionsResult.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MeetingTimeSuggestionsResult>))]
    public partial class MeetingTimeSuggestionsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingTimeSuggestionsResult"/> class.
        /// </summary>
        public MeetingTimeSuggestionsResult()
        {
        }

        /// <summary>
        /// Gets or sets emptySuggestionsReason.
        /// A reason for not returning any meeting suggestions. Possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.
        /// </summary>
        [JsonPropertyName("emptySuggestionsReason")]
        public string EmptySuggestionsReason { get; set; }
    
        /// <summary>
        /// Gets or sets meetingTimeSuggestions.
        /// An array of meeting suggestions.
        /// </summary>
        [JsonPropertyName("meetingTimeSuggestions")]
        public IEnumerable<MeetingTimeSuggestion> MeetingTimeSuggestions { get; set; }
    
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
