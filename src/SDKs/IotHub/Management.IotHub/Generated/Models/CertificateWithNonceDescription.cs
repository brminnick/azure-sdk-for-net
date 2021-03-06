// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X509 Certificate.
    /// </summary>
    public partial class CertificateWithNonceDescription : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateWithNonceDescription
        /// class.
        /// </summary>
        public CertificateWithNonceDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateWithNonceDescription
        /// class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The name of the certificate.</param>
        /// <param name="etag">The entity tag.</param>
        /// <param name="type">The resource type.</param>
        public CertificateWithNonceDescription(CertificatePropertiesWithNonce properties = default(CertificatePropertiesWithNonce), string id = default(string), string name = default(string), string etag = default(string), string type = default(string))
        {
            Properties = properties;
            Id = id;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CertificatePropertiesWithNonce Properties { get; set; }

        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the entity tag.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
