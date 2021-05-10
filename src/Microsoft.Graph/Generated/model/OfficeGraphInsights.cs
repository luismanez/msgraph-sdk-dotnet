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
    /// The type Office Graph Insights.
    /// </summary>
    public partial class OfficeGraphInsights : Entity
    {
    
        ///<summary>
        /// The OfficeGraphInsights constructor
        ///</summary>
        public OfficeGraphInsights()
        {
        }

        /// <summary>
        /// Gets or sets shared.
        /// Calculated relationship identifying documents shared with or by the user. This includes URLs, file attachments, and reference attachments to OneDrive for Business and SharePoint files found in Outlook messages and meetings. This also includes URLs and reference attachments to Teams conversations. Ordered by recency of share.
        /// </summary>
        [JsonPropertyName("shared")]
        public IOfficeGraphInsightsSharedCollectionPage Shared { get; set; }

        /// <summary>
        /// Gets or sets sharedNextLink.
        /// </summary>
        [JsonPropertyName("shared@odata.nextLink")]
        public string SharedNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets trending.
        /// Calculated relationship identifying documents trending around a user. Trending documents are calculated based on activity of the user's closest network of people and include files stored in OneDrive for Business and SharePoint. Trending insights help the user to discover potentially useful content that the user has access to, but has never viewed before.
        /// </summary>
        [JsonPropertyName("trending")]
        public IOfficeGraphInsightsTrendingCollectionPage Trending { get; set; }

        /// <summary>
        /// Gets or sets trendingNextLink.
        /// </summary>
        [JsonPropertyName("trending@odata.nextLink")]
        public string TrendingNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets used.
        /// Calculated relationship identifying the latest documents viewed or modified by a user, including OneDrive for Business and SharePoint documents, ranked by recency of use.
        /// </summary>
        [JsonPropertyName("used")]
        public IOfficeGraphInsightsUsedCollectionPage Used { get; set; }

        /// <summary>
        /// Gets or sets usedNextLink.
        /// </summary>
        [JsonPropertyName("used@odata.nextLink")]
        public string UsedNextLink { get; set; }
    
    }
}

