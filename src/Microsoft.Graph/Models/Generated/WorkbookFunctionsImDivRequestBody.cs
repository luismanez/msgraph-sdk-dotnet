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
    /// The type WorkbookFunctionsImDivRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsImDivRequestBody
    {
    
        /// <summary>
        /// Gets or sets Inumber1.
        /// </summary>
        [DataMember(Name = "inumber1", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Inumber1 { get; set; }
    
        /// <summary>
        /// Gets or sets Inumber2.
        /// </summary>
        [DataMember(Name = "inumber2", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Inumber2 { get; set; }
    
    }
}
