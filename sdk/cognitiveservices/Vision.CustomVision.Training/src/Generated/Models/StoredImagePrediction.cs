// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of an image prediction request.
    /// </summary>
    public partial class StoredImagePrediction
    {
        /// <summary>
        /// Initializes a new instance of the StoredImagePrediction class.
        /// </summary>
        public StoredImagePrediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoredImagePrediction class.
        /// </summary>
        /// <param name="resizedImageUri">The URI to the (resized) prediction
        /// image.</param>
        /// <param name="thumbnailUri">The URI to the thumbnail of the original
        /// prediction image.</param>
        /// <param name="originalImageUri">The URI to the original prediction
        /// image.</param>
        /// <param name="domain">Domain used for the prediction.</param>
        /// <param name="id">Prediction Id.</param>
        /// <param name="project">Project Id.</param>
        /// <param name="iteration">Iteration Id.</param>
        /// <param name="created">Date this prediction was created.</param>
        /// <param name="predictions">List of predictions.</param>
        public StoredImagePrediction(string resizedImageUri = default(string), string thumbnailUri = default(string), string originalImageUri = default(string), System.Guid domain = default(System.Guid), System.Guid id = default(System.Guid), System.Guid project = default(System.Guid), System.Guid iteration = default(System.Guid), System.DateTime created = default(System.DateTime), IList<Prediction> predictions = default(IList<Prediction>))
        {
            ResizedImageUri = resizedImageUri;
            ThumbnailUri = thumbnailUri;
            OriginalImageUri = originalImageUri;
            Domain = domain;
            Id = id;
            Project = project;
            Iteration = iteration;
            Created = created;
            Predictions = predictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URI to the (resized) prediction image.
        /// </summary>
        [JsonProperty(PropertyName = "resizedImageUri")]
        public string ResizedImageUri { get; private set; }

        /// <summary>
        /// Gets the URI to the thumbnail of the original prediction image.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUri")]
        public string ThumbnailUri { get; private set; }

        /// <summary>
        /// Gets the URI to the original prediction image.
        /// </summary>
        [JsonProperty(PropertyName = "originalImageUri")]
        public string OriginalImageUri { get; private set; }

        /// <summary>
        /// Gets domain used for the prediction.
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public System.Guid Domain { get; private set; }

        /// <summary>
        /// Gets prediction Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets project Id.
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public System.Guid Project { get; private set; }

        /// <summary>
        /// Gets iteration Id.
        /// </summary>
        [JsonProperty(PropertyName = "iteration")]
        public System.Guid Iteration { get; private set; }

        /// <summary>
        /// Gets date this prediction was created.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets list of predictions.
        /// </summary>
        [JsonProperty(PropertyName = "predictions")]
        public IList<Prediction> Predictions { get; private set; }

    }
}
