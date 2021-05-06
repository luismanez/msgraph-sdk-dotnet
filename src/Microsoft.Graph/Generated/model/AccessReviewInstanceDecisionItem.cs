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
    /// The type Access Review Instance Decision Item.
    /// </summary>
    public partial class AccessReviewInstanceDecisionItem : Entity
    {
    
        ///<summary>
        /// The AccessReviewInstanceDecisionItem constructor
        ///</summary>
        public AccessReviewInstanceDecisionItem()
        {
        }

        /// <summary>
        /// Gets or sets access review id.
        /// The identifier of the accessReviewInstance parent.
        /// </summary>
        [JsonPropertyName("accessReviewId")]
        public string AccessReviewId { get; set; }
    
        /// <summary>
        /// Gets or sets applied by.
        /// The identifier of the user who applied the decision.
        /// </summary>
        [JsonPropertyName("appliedBy")]
        public UserIdentity AppliedBy { get; set; }
    
        /// <summary>
        /// Gets or sets applied date time.
        /// The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("appliedDateTime")]
        public DateTimeOffset? AppliedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets apply result.
        /// The result of applying the decision. Possible values: NotApplied, Success, Failed, NotFound, or NotSupported.
        /// </summary>
        [JsonPropertyName("applyResult")]
        public string ApplyResult { get; set; }
    
        /// <summary>
        /// Gets or sets decision.
        /// Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow.
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// The review decision justification.
        /// </summary>
        [JsonPropertyName("justification")]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// Every decision item in an access review represents a principal's access to a resource. This property represents details of the principal. For example, if a decision item represents access of User 'Bob' to Group 'Sales' - The principal is 'Bob' and the resource is 'Sales'. Principals can be of two types - userIdentity and servicePrincipalIdentity.
        /// </summary>
        [JsonPropertyName("principal")]
        public Identity Principal { get; set; }
    
        /// <summary>
        /// Gets or sets principal link.
        /// </summary>
        [JsonPropertyName("principalLink")]
        public string PrincipalLink { get; set; }
    
        /// <summary>
        /// Gets or sets recommendation.
        /// A system-generated recommendation for the approval decision. Possible values: Approve, Deny, or NotAvailable.
        /// </summary>
        [JsonPropertyName("recommendation")]
        public string Recommendation { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Every decision item in an access review represents a principal's access to a resource. This property represents details of the resource. For example, if a decision item represents access of User 'Bob' to Group 'Sales' - The principal is Bob and the resource is 'Sales'. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource
        /// </summary>
        [JsonPropertyName("resource")]
        public AccessReviewInstanceDecisionItemResource Resource { get; set; }
    
        /// <summary>
        /// Gets or sets resource link.
        /// </summary>
        [JsonPropertyName("resourceLink")]
        public string ResourceLink { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed by.
        /// The identifier of the reviewer.
        /// </summary>
        [JsonPropertyName("reviewedBy")]
        public UserIdentity ReviewedBy { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed date time.
        /// The timestamp when the review occurred.
        /// </summary>
        [JsonPropertyName("reviewedDateTime")]
        public DateTimeOffset? ReviewedDateTime { get; set; }
    
    }
}
