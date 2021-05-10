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
    /// The type Drive Item.
    /// </summary>
    public partial class DriveItem : BaseItem
    {
    
        ///<summary>
        /// The DriveItem constructor
        ///</summary>
        public DriveItem()
        {
            this.ODataType = "microsoft.graph.driveItem";
        }
    
        /// <summary>
        /// Gets or sets audio.
        /// Audio metadata, if the item is an audio file. Read-only.
        /// </summary>
        [JsonPropertyName("audio")]
        public Audio Audio { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// The content stream, if the item represents a file.
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets c tag.
        /// An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.
        /// </summary>
        [JsonPropertyName("cTag")]
        public string CTag { get; set; }
    
        /// <summary>
        /// Gets or sets deleted.
        /// Information about the deleted state of the item. Read-only.
        /// </summary>
        [JsonPropertyName("deleted")]
        public Deleted Deleted { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// File metadata, if the item is a file. Read-only.
        /// </summary>
        [JsonPropertyName("file")]
        public File File { get; set; }
    
        /// <summary>
        /// Gets or sets file system info.
        /// File system information on client. Read-write.
        /// </summary>
        [JsonPropertyName("fileSystemInfo")]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets folder.
        /// Folder metadata, if the item is a folder. Read-only.
        /// </summary>
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; }
    
        /// <summary>
        /// Gets or sets image.
        /// Image metadata, if the item is an image. Read-only.
        /// </summary>
        [JsonPropertyName("image")]
        public Image Image { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Location metadata, if the item has location data. Read-only.
        /// </summary>
        [JsonPropertyName("location")]
        public GeoCoordinates Location { get; set; }
    
        /// <summary>
        /// Gets or sets package.
        /// If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.
        /// </summary>
        [JsonPropertyName("package")]
        public Package Package { get; set; }
    
        /// <summary>
        /// Gets or sets pending operations.
        /// If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.
        /// </summary>
        [JsonPropertyName("pendingOperations")]
        public PendingOperations PendingOperations { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// Photo metadata, if the item is a photo. Read-only.
        /// </summary>
        [JsonPropertyName("photo")]
        public Photo Photo { get; set; }
    
        /// <summary>
        /// Gets or sets publication.
        /// Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.
        /// </summary>
        [JsonPropertyName("publication")]
        public PublicationFacet Publication { get; set; }
    
        /// <summary>
        /// Gets or sets remote item.
        /// Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.
        /// </summary>
        [JsonPropertyName("remoteItem")]
        public RemoteItem RemoteItem { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.
        /// </summary>
        [JsonPropertyName("root")]
        public Root Root { get; set; }
    
        /// <summary>
        /// Gets or sets search result.
        /// Search metadata, if the item is from a search result. Read-only.
        /// </summary>
        [JsonPropertyName("searchResult")]
        public SearchResult SearchResult { get; set; }
    
        /// <summary>
        /// Gets or sets shared.
        /// Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.
        /// </summary>
        [JsonPropertyName("shared")]
        public Shared Shared { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonPropertyName("sharepointIds")]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// Size of the item in bytes. Read-only.
        /// </summary>
        [JsonPropertyName("size")]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets special folder.
        /// If the current item is also available as a special folder, this facet is returned. Read-only.
        /// </summary>
        [JsonPropertyName("specialFolder")]
        public SpecialFolder SpecialFolder { get; set; }
    
        /// <summary>
        /// Gets or sets video.
        /// Video metadata, if the item is a video. Read-only.
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }
    
        /// <summary>
        /// Gets or sets web dav url.
        /// WebDAV compatible URL for the item.
        /// </summary>
        [JsonPropertyName("webDavUrl")]
        public string WebDavUrl { get; set; }
    
        /// <summary>
        /// Gets or sets workbook.
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// </summary>
        [JsonPropertyName("workbook")]
        public Workbook Workbook { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place on this item.
        /// </summary>
        [JsonPropertyName("analytics")]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("children")]
        public IDriveItemChildrenCollectionPage Children { get; set; }

        /// <summary>
        /// Gets or sets childrenNextLink.
        /// </summary>
        [JsonPropertyName("children@odata.nextLink")]
        public string ChildrenNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets list item.
        /// For drives in SharePoint, the associated document library list item. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("listItem")]
        public ListItem ListItem { get; set; }
    
        /// <summary>
        /// Gets or sets permissions.
        /// The set of permissions for the item. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("permissions")]
        public IDriveItemPermissionsCollectionPage Permissions { get; set; }

        /// <summary>
        /// Gets or sets permissionsNextLink.
        /// </summary>
        [JsonPropertyName("permissions@odata.nextLink")]
        public string PermissionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptions.
        /// The set of subscriptions on the item. Only supported on the root of a drive.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public IDriveItemSubscriptionsCollectionPage Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets subscriptionsNextLink.
        /// </summary>
        [JsonPropertyName("subscriptions@odata.nextLink")]
        public string SubscriptionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnails.
        /// Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("thumbnails")]
        public IDriveItemThumbnailsCollectionPage Thumbnails { get; set; }

        /// <summary>
        /// Gets or sets thumbnailsNextLink.
        /// </summary>
        [JsonPropertyName("thumbnails@odata.nextLink")]
        public string ThumbnailsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets versions.
        /// The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("versions")]
        public IDriveItemVersionsCollectionPage Versions { get; set; }

        /// <summary>
        /// Gets or sets versionsNextLink.
        /// </summary>
        [JsonPropertyName("versions@odata.nextLink")]
        public string VersionsNextLink { get; set; }
    
    }
}

