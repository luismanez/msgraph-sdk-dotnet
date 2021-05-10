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
    /// The type Onenote.
    /// </summary>
    public partial class Onenote : Entity
    {
    
        ///<summary>
        /// The Onenote constructor
        ///</summary>
        public Onenote()
        {
        }

        /// <summary>
        /// Gets or sets notebooks.
        /// The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("notebooks")]
        public IOnenoteNotebooksCollectionPage Notebooks { get; set; }

        /// <summary>
        /// Gets or sets notebooksNextLink.
        /// </summary>
        [JsonPropertyName("notebooks@odata.nextLink")]
        public string NotebooksNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("operations")]
        public IOnenoteOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets pages.
        /// The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("pages")]
        public IOnenotePagesCollectionPage Pages { get; set; }

        /// <summary>
        /// Gets or sets pagesNextLink.
        /// </summary>
        [JsonPropertyName("pages@odata.nextLink")]
        public string PagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("resources")]
        public IOnenoteResourcesCollectionPage Resources { get; set; }

        /// <summary>
        /// Gets or sets resourcesNextLink.
        /// </summary>
        [JsonPropertyName("resources@odata.nextLink")]
        public string ResourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets section groups.
        /// The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("sectionGroups")]
        public IOnenoteSectionGroupsCollectionPage SectionGroups { get; set; }

        /// <summary>
        /// Gets or sets sectionGroupsNextLink.
        /// </summary>
        [JsonPropertyName("sectionGroups@odata.nextLink")]
        public string SectionGroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sections.
        /// The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("sections")]
        public IOnenoteSectionsCollectionPage Sections { get; set; }

        /// <summary>
        /// Gets or sets sectionsNextLink.
        /// </summary>
        [JsonPropertyName("sections@odata.nextLink")]
        public string SectionsNextLink { get; set; }
    
    }
}

