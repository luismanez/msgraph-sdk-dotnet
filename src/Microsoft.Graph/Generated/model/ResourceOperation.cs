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
    /// The type Resource Operation.
    /// </summary>
    public partial class ResourceOperation : Entity
    {
    
        ///<summary>
        /// The ResourceOperation constructor
        ///</summary>
        public ResourceOperation()
        {
        }

        /// <summary>
        /// Gets or sets action name.
        /// Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.
        /// </summary>
        [JsonPropertyName("actionName")]
        public string ActionName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets resource name.
        /// Name of the Resource this operation is performed on.
        /// </summary>
        [JsonPropertyName("resourceName")]
        public string ResourceName { get; set; }
    
    }
}

