// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Session.
    /// </summary>
    public partial class Session : Microsoft.Graph.Entity
    {
    
        ///<summary>
        /// The Session constructor
        ///</summary>
        public Session()
        {
        }

        /// <summary>
        /// Gets or sets callee.
        /// Endpoint that answered the session.
        /// </summary>
        [JsonPropertyName("callee")]
        public Endpoint Callee { get; set; }
    
        /// <summary>
        /// Gets or sets caller.
        /// Endpoint that initiated the session.
        /// </summary>
        [JsonPropertyName("caller")]
        public Endpoint Caller { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// UTC time when the last user left the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets failure info.
        /// Failure information associated with the session if the session failed.
        /// </summary>
        [JsonPropertyName("failureInfo")]
        public FailureInfo FailureInfo { get; set; }
    
        /// <summary>
        /// Gets or sets modalities.
        /// List of modalities present in the session. Possible values are: unknown, audio, video, videoBasedScreenSharing, data, screenSharing, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("modalities")]
        public IEnumerable<Modality> Modalities { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// UTC time when the first user joined the session. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets segments.
        /// The list of segments involved in the session. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("segments")]
        public ISessionSegmentsCollectionPage Segments { get; set; }

        /// <summary>
        /// Gets or sets segmentsNextLink.
        /// </summary>
        [JsonPropertyName("segments@odata.nextLink")]
        public string SegmentsNextLink { get; set; }
    
    }
}

