// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response containing search results from an index.
    /// </summary>
    public partial class DocumentSearchResult<T>
    {
        /// <summary>
        /// Initializes a new instance of the DocumentSearchResult class.
        /// </summary>
        internal DocumentSearchResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSearchResult class.
        /// </summary>
        /// <param name="count">The total count of results found by the search
        /// operation, or null if the count was not requested. If present, the
        /// count may be greater than the number of results in this response.
        /// This can happen if you use the $top or $skip parameters, or if
        /// Azure Cognitive Search can't return all the requested documents in
        /// a single Search response.</param>
        /// <param name="coverage">A value indicating the percentage of the
        /// index that was included in the query, or null if minimumCoverage
        /// was not specified in the request.</param>
        /// <param name="facets">The facet query results for the search
        /// operation, organized as a collection of buckets for each faceted
        /// field; null if the query did not include any facet
        /// expressions.</param>
        /// <param name="nextPageParameters">Continuation JSON payload returned
        /// when Azure Cognitive Search can't return all the requested results
        /// in a single Search response. You can use this JSON along with
        /// @odata.nextLink to formulate another POST Search request to get the
        /// next part of the search response.</param>
        /// <param name="results">The sequence of results returned by the
        /// query.</param>
        /// <param name="nextLink">Continuation URL returned when Azure
        /// Cognitive Search can't return all the requested results in a single
        /// Search response. You can use this URL to formulate another GET or
        /// POST Search request to get the next part of the search response.
        /// Make sure to use the same verb (GET or POST) as the request that
        /// produced this response.</param>
        internal DocumentSearchResult(long? count = default(long?), double? coverage = default(double?), IDictionary<string, IList<FacetResult>> facets = default(IDictionary<string, IList<FacetResult>>), SearchRequest nextPageParameters = default(SearchRequest), IList<SearchResult<T>> results = default(IList<SearchResult<T>>), string nextLink = default(string))
        {
            Count = count;
            Coverage = coverage;
            Facets = facets;
            NextPageParameters = nextPageParameters;
            Results = results;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the total count of results found by the search operation, or
        /// null if the count was not requested. If present, the count may be
        /// greater than the number of results in this response. This can
        /// happen if you use the $top or $skip parameters, or if Azure
        /// Cognitive Search can't return all the requested documents in a
        /// single Search response.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.count")]
        public long? Count { get; private set; }

        /// <summary>
        /// Gets a value indicating the percentage of the index that was
        /// included in the query, or null if minimumCoverage was not specified
        /// in the request.
        /// </summary>
        [JsonProperty(PropertyName = "@search.coverage")]
        public double? Coverage { get; private set; }

        /// <summary>
        /// Gets the facet query results for the search operation, organized as
        /// a collection of buckets for each faceted field; null if the query
        /// did not include any facet expressions.
        /// </summary>
        [JsonProperty(PropertyName = "@search.facets")]
        public IDictionary<string, IList<FacetResult>> Facets { get; private set; }

        /// <summary>
        /// Gets continuation JSON payload returned when Azure Cognitive Search
        /// can't return all the requested results in a single Search response.
        /// You can use this JSON along with @odata.nextLink to formulate
        /// another POST Search request to get the next part of the search
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "@search.nextPageParameters")]
        internal SearchRequest NextPageParameters { get; private set; }

        /// <summary>
        /// Gets the sequence of results returned by the query.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SearchResult<T>> Results { get; private set; }

        /// <summary>
        /// Gets continuation URL returned when Azure Cognitive Search can't
        /// return all the requested results in a single Search response. You
        /// can use this URL to formulate another GET or POST Search request to
        /// get the next part of the search response. Make sure to use the same
        /// verb (GET or POST) as the request that produced this response.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.nextLink")]
        internal string NextLink { get; private set; }

    }
}
