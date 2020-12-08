// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CloudCommunicationsPresencesCollectionRequestBuilder.
    /// </summary>
    public partial class CloudCommunicationsPresencesCollectionRequestBuilder : BaseRequestBuilder, ICloudCommunicationsPresencesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CloudCommunicationsPresencesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CloudCommunicationsPresencesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICloudCommunicationsPresencesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICloudCommunicationsPresencesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CloudCommunicationsPresencesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPresenceRequestBuilder"/> for the specified CloudCommunicationsPresence.
        /// </summary>
        /// <param name="id">The ID for the CloudCommunicationsPresence.</param>
        /// <returns>The <see cref="IPresenceRequestBuilder"/>.</returns>
        public IPresenceRequestBuilder this[string id]
        {
            get
            {
                return new PresenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}