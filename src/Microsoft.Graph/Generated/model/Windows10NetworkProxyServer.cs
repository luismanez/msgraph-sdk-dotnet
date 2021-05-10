// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Windows10NetworkProxyServer.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10NetworkProxyServer>))]
    public partial class Windows10NetworkProxyServer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Windows10NetworkProxyServer"/> class.
        /// </summary>
        public Windows10NetworkProxyServer()
        {
        }

        /// <summary>
        /// Gets or sets address.
        /// Address to the proxy server. Specify an address in the format &amp;lt;server&amp;gt;[:&amp;lt;port&amp;gt;]
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or sets exceptions.
        /// Addresses that should not use the proxy server. The system will not use the proxy server for addresses beginning with what is specified in this node.
        /// </summary>
        [JsonPropertyName("exceptions")]
        public IEnumerable<string> Exceptions { get; set; }
    
        /// <summary>
        /// Gets or sets useForLocalAddresses.
        /// Specifies whether the proxy server should be used for local (intranet) addresses.
        /// </summary>
        [JsonPropertyName("useForLocalAddresses")]
        public bool? UseForLocalAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
