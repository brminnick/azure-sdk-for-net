// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The KPI extract.
    /// </summary>
    public partial class KpiExtract
    {
        /// <summary>
        /// Initializes a new instance of the KpiExtract class.
        /// </summary>
        public KpiExtract() { }

        /// <summary>
        /// Initializes a new instance of the KpiExtract class.
        /// </summary>
        /// <param name="extractName">KPI extract name.</param>
        /// <param name="expression">The expression.</param>
        public KpiExtract(string extractName, string expression)
        {
            ExtractName = extractName;
            Expression = expression;
        }

        /// <summary>
        /// Gets or sets KPI extract name.
        /// </summary>
        [JsonProperty(PropertyName = "extractName")]
        public string ExtractName { get; set; }

        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExtractName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExtractName");
            }
            if (Expression == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Expression");
            }
        }
    }
}

