// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGroupMembersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IGroupMembersCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGroupMembersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGroupMembersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified DirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the DirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IGroupMembersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IGroupMembersCollectionReferencesRequestBuilder"/>.</returns>
        IGroupMembersCollectionReferencesRequestBuilder References { get; }

    }
}
