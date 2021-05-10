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
    /// The type Shift.
    /// </summary>
    public partial class Shift : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The Shift constructor
        ///</summary>
        public Shift()
        {
        }

        /// <summary>
        /// Gets or sets draft shift.
        /// The draft version of this shift that is viewable by managers. Required.
        /// </summary>
        [JsonPropertyName("draftShift")]
        public ShiftItem DraftShift { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling group id.
        /// ID of the scheduling group the shift is part of. Required.
        /// </summary>
        [JsonPropertyName("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets shared shift.
        /// The shared version of this shift that is viewable by both employees and managers. Required.
        /// </summary>
        [JsonPropertyName("sharedShift")]
        public ShiftItem SharedShift { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// ID of the user assigned to the shift. Required.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
    }
}

