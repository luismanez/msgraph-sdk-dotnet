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
    /// The type WorkbookFunctionsDollarFrRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsDollarFrRequestBody
    {
    
        /// <summary>
        /// Gets or sets DecimalDollar.
        /// </summary>
        [DataMember(Name = "decimalDollar", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken DecimalDollar { get; set; }
    
        /// <summary>
        /// Gets or sets Fraction.
        /// </summary>
        [DataMember(Name = "fraction", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Fraction { get; set; }
    
    }
}
