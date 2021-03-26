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
    /// Matrix column mapping
    /// </summary>
    [DataContract]
        public partial class MatrixCustomMappingApiColumnResultItemRm :  IEquatable<MatrixCustomMappingApiColumnResultItemRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixCustomMappingApiColumnResultItemRm" /> class.
        /// </summary>
        /// <param name="jsonCustomName">Json custom name (required).</param>
        public MatrixCustomMappingApiColumnResultItemRm(string jsonCustomName = default(string))
        {
            // to ensure "jsonCustomName" is required (not null)
            if (jsonCustomName == null)
            {
                throw new InvalidDataException("jsonCustomName is a required property for MatrixCustomMappingApiColumnResultItemRm and cannot be null");
            }
            else
            {
                this.JsonCustomName = jsonCustomName;
            }
        }
        
        /// <summary>
        /// Json custom name
        /// </summary>
        /// <value>Json custom name</value>
        [DataMember(Name="jsonCustomName", EmitDefaultValue=false)]
        public string JsonCustomName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatrixCustomMappingApiColumnResultItemRm {\n");
            sb.Append("  JsonCustomName: ").Append(JsonCustomName).Append("\n");
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
            return this.Equals(input as MatrixCustomMappingApiColumnResultItemRm);
        }

        /// <summary>
        /// Returns true if MatrixCustomMappingApiColumnResultItemRm instances are equal
        /// </summary>
        /// <param name="input">Instance of MatrixCustomMappingApiColumnResultItemRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatrixCustomMappingApiColumnResultItemRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JsonCustomName == input.JsonCustomName ||
                    (this.JsonCustomName != null &&
                    this.JsonCustomName.Equals(input.JsonCustomName))
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
                if (this.JsonCustomName != null)
                    hashCode = hashCode * 59 + this.JsonCustomName.GetHashCode();
                return hashCode;
            }
        }

    }
}