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
    /// The type Teamwork.
    /// </summary>
    public partial class Teamwork : Entity
    {
    
        ///<summary>
        /// The Teamwork constructor
        ///</summary>
        public Teamwork()
        {
        }

        /// <summary>
        /// Gets or sets workforce integrations.
        /// </summary>
        [JsonPropertyName("workforceIntegrations")]
        public ITeamworkWorkforceIntegrationsCollectionPage WorkforceIntegrations { get; set; }

        /// <summary>
        /// Gets or sets workforceIntegrationsNextLink.
        /// </summary>
        [JsonPropertyName("workforceIntegrations@odata.nextLink")]
        public string WorkforceIntegrationsNextLink { get; set; }
    
    }
}

