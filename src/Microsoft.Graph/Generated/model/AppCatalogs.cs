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
    /// The type App Catalogs.
    /// </summary>
    public partial class AppCatalogs : Entity
    {
    
        ///<summary>
        /// The AppCatalogs constructor
        ///</summary>
        public AppCatalogs()
        {
        }

        /// <summary>
        /// Gets or sets teams apps.
        /// </summary>
        [JsonPropertyName("teamsApps")]
        public IAppCatalogsTeamsAppsCollectionPage TeamsApps { get; set; }

        /// <summary>
        /// Gets or sets teamsAppsNextLink.
        /// </summary>
        [JsonPropertyName("teamsApps@odata.nextLink")]
        public string TeamsAppsNextLink { get; set; }
    
    }
}

