/* 
 * ARXivar Workflow API
 *
 * ARXivar Workflow API
 *
 * OpenAPI spec version: v1
 * Contact: info@abletech.it
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Workflow.Client.SwaggerDateConverter;

namespace IO.Swagger.Workflow.Model
{
    /// <summary>
    /// Serach response model
    /// </summary>
    [DataContract]
        public partial class LogEntryRmSearchResponseRm :  IEquatable<LogEntryRmSearchResponseRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntryRmSearchResponseRm" /> class.
        /// </summary>
        /// <param name="resultCount">resultCount.</param>
        /// <param name="items">Result list items.</param>
        public LogEntryRmSearchResponseRm(SearchResultCountRm resultCount = default(SearchResultCountRm), List<LogEntryRm> items = default(List<LogEntryRm>))
        {
            this.ResultCount = resultCount;
            this.Items = items;
        }
        
        /// <summary>
        /// Gets or Sets ResultCount
        /// </summary>
        [DataMember(Name="resultCount", EmitDefaultValue=false)]
        public SearchResultCountRm ResultCount { get; set; }

        /// <summary>
        /// Result list items
        /// </summary>
        /// <value>Result list items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<LogEntryRm> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogEntryRmSearchResponseRm {\n");
            sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogEntryRmSearchResponseRm);
        }

        /// <summary>
        /// Returns true if LogEntryRmSearchResponseRm instances are equal
        /// </summary>
        /// <param name="input">Instance of LogEntryRmSearchResponseRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogEntryRmSearchResponseRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultCount == input.ResultCount ||
                    (this.ResultCount != null &&
                    this.ResultCount.Equals(input.ResultCount))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResultCount != null)
                    hashCode = hashCode * 59 + this.ResultCount.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

    }
}
