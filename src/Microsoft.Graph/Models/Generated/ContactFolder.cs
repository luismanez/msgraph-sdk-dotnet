// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Contact Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ContactFolder : Entity
    {
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contacts", Required = Required.Default)]
        public IContactFolderContactsCollectionPage Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolders", Required = Required.Default)]
        public IContactFolderChildFoldersCollectionPage ChildFolders { get; set; }
    
    }
}

