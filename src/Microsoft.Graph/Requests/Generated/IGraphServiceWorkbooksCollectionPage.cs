// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IGraphServiceWorkbooksCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<GraphServiceWorkbooksCollectionPage>))]
    public interface IGraphServiceWorkbooksCollectionPage : ICollectionPage<DriveItem>
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceWorkbooksCollectionRequest"/> instance.
        /// </summary>
        IGraphServiceWorkbooksCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
