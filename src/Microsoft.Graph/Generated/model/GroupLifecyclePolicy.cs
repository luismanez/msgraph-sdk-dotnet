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
    /// The type Group Lifecycle Policy.
    /// </summary>
    public partial class GroupLifecyclePolicy : Entity
    {
    
        ///<summary>
        /// The GroupLifecyclePolicy constructor
        ///</summary>
        public GroupLifecyclePolicy()
        {
        }

        /// <summary>
        /// Gets or sets alternate notification emails.
        /// List of email address to send notifications for groups without owners. Multiple email address can be defined by separating email address with a semicolon.
        /// </summary>
        [JsonPropertyName("alternateNotificationEmails")]
        public string AlternateNotificationEmails { get; set; }
    
        /// <summary>
        /// Gets or sets group lifetime in days.
        /// Number of days before a group expires and needs to be renewed. Once renewed, the group expiration is extended by the number of days defined.
        /// </summary>
        [JsonPropertyName("groupLifetimeInDays")]
        public Int32? GroupLifetimeInDays { get; set; }
    
        /// <summary>
        /// Gets or sets managed group types.
        /// The group type for which the expiration policy applies. Possible values are All, Selected or None.
        /// </summary>
        [JsonPropertyName("managedGroupTypes")]
        public string ManagedGroupTypes { get; set; }
    
    }
}

