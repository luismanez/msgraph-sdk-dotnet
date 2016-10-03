// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsIfRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsIfRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsIfRequest>, IWorkbookFunctionsIfRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsIfRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="logicalTest">A logicalTest parameter for the OData method call.</param>
        /// <param name="valueIfTrue">A valueIfTrue parameter for the OData method call.</param>
        /// <param name="valueIfFalse">A valueIfFalse parameter for the OData method call.</param>
        public WorkbookFunctionsIfRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken logicalTest,
            Newtonsoft.Json.Linq.JToken valueIfTrue,
            Newtonsoft.Json.Linq.JToken valueIfFalse)
            : base(requestUrl, client)
        {
            this.SetParameter("logicalTest", logicalTest, true);
            this.SetParameter("valueIfTrue", valueIfTrue, true);
            this.SetParameter("valueIfFalse", valueIfFalse, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsIfRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsIfRequest(functionUrl, this.Client, options);

            if (this.HasParameter("logicalTest"))
            {
                request.RequestBody.LogicalTest = this.GetParameter<Newtonsoft.Json.Linq.JToken>("logicalTest");
            }

            if (this.HasParameter("valueIfTrue"))
            {
                request.RequestBody.ValueIfTrue = this.GetParameter<Newtonsoft.Json.Linq.JToken>("valueIfTrue");
            }

            if (this.HasParameter("valueIfFalse"))
            {
                request.RequestBody.ValueIfFalse = this.GetParameter<Newtonsoft.Json.Linq.JToken>("valueIfFalse");
            }

            return request;
        }
    }
}
