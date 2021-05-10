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
    /// The type Scheduling Group.
    /// </summary>
    public partial class SchedulingGroup : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The SchedulingGroup constructor
        ///</summary>
        public SchedulingGroup()
        {
        }

        /// <summary>
        /// Gets or sets display name.
        /// The display name for the schedulingGroup. Required.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Indicates whether the schedulingGroup can be used when creating new entities or updating existing ones. Required.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets user ids.
        /// The list of user IDs that are a member of the schedulingGroup. Required.
        /// </summary>
        [JsonPropertyName("userIds")]
        public IEnumerable<string> UserIds { get; set; }
    
    }
}

