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
    /// The type Used Insight.
    /// </summary>
    public partial class UsedInsight : Entity
    {
    
        ///<summary>
        /// The UsedInsight constructor
        ///</summary>
        public UsedInsight()
        {
        }

        /// <summary>
        /// Gets or sets last used.
        /// Information about when the item was last viewed or modified by the user. Read only.
        /// </summary>
        [JsonPropertyName("lastUsed")]
        public UsageDetails LastUsed { get; set; }
    
        /// <summary>
        /// Gets or sets resource reference.
        /// Reference properties of the used document, such as the url and type of the document. Read-only
        /// </summary>
        [JsonPropertyName("resourceReference")]
        public ResourceReference ResourceReference { get; set; }
    
        /// <summary>
        /// Gets or sets resource visualization.
        /// Properties that you can use to visualize the document in your experience. Read-only
        /// </summary>
        [JsonPropertyName("resourceVisualization")]
        public ResourceVisualization ResourceVisualization { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
        /// </summary>
        [JsonPropertyName("resource")]
        public Entity Resource { get; set; }
    
    }
}

