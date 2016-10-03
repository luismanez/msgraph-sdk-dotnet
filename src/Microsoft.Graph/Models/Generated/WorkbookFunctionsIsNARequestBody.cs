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

    /// <summary>
    /// The type WorkbookFunctionsIsNARequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsIsNARequestBody
    {
    
        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Value { get; set; }
    
    }
}
