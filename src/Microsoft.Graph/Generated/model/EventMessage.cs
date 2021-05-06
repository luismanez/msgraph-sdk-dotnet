// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Event Message.
    /// </summary>
    public partial class EventMessage : Message
    {
    
        ///<summary>
        /// The EventMessage constructor
        ///</summary>
        public EventMessage()
        {
            this.ODataType = "microsoft.graph.eventMessage";
        }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The end time of the requested meeting.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeTimeZone EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is all day.
        /// </summary>
        [JsonPropertyName("isAllDay")]
        public bool? IsAllDay { get; set; }
    
        /// <summary>
        /// Gets or sets is delegated.
        /// True if this meeting request is accessible to a delegate, false otherwise. Default is false.
        /// </summary>
        [JsonPropertyName("isDelegated")]
        public bool? IsDelegated { get; set; }
    
        /// <summary>
        /// Gets or sets is out of date.
        /// </summary>
        [JsonPropertyName("isOutOfDate")]
        public bool? IsOutOfDate { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }
    
        /// <summary>
        /// Gets or sets meeting message type.
        /// The type of event message: none, meetingRequest, meetingCancelled, meetingAccepted, meetingTenativelyAccepted, meetingDeclined.
        /// </summary>
        [JsonPropertyName("meetingMessageType")]
        public MeetingMessageType? MeetingMessageType { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeTimeZone StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public EventType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets event.
        /// The event associated with the event message. The assumption for attendees or room resources is that the Calendar Attendant is set to automatically update the calendar with an event when meeting request event messages arrive. Navigation property.  Read-only.
        /// </summary>
        [JsonPropertyName("event")]
        public Event Event { get; set; }
    
    }
}

