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
    /// The type Admin Consent Request Policy.
    /// </summary>
    public partial class AdminConsentRequestPolicy : Entity
    {
    
        ///<summary>
        /// The AdminConsentRequestPolicy constructor
        ///</summary>
        public AdminConsentRequestPolicy()
        {
        }

        /// <summary>
        /// Gets or sets is enabled.
        /// Specifies whether the admin consent request feature is enabled or disabled. Required.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets notify reviewers.
        /// Specifies whether reviewers will receive notifications. Required.
        /// </summary>
        [JsonPropertyName("notifyReviewers")]
        public bool? NotifyReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets reminders enabled.
        /// Specifies whether reviewers will receive reminder emails. Required.
        /// </summary>
        [JsonPropertyName("remindersEnabled")]
        public bool? RemindersEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets request duration in days.
        /// Specifies the duration the request is active before it automatically expires if no decision is applied.
        /// </summary>
        [JsonPropertyName("requestDurationInDays")]
        public Int32? RequestDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets reviewers.
        /// The list of reviewers for the admin consent. Required.
        /// </summary>
        [JsonPropertyName("reviewers")]
        public IEnumerable<AccessReviewReviewerScope> Reviewers { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Specifies the version of this policy. When the policy is updated, this version is updated. Read-only.
        /// </summary>
        [JsonPropertyName("version")]
        public Int32? Version { get; set; }
    
    }
}

