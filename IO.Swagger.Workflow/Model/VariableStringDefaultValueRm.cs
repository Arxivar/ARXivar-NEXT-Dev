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
    /// VariableStringDefaultValueRm
    /// </summary>
    [DataContract]
        public partial class VariableStringDefaultValueRm : VariableDefaultValueRm,  IEquatable<VariableStringDefaultValueRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableStringDefaultValueRm" /> class.
        /// </summary>
        /// <param name="value">Variable value.</param>
        public VariableStringDefaultValueRm(string value = default(string), int? variableType = default(int?)) : base(variableType)
        {
            this.Value = value;
        }
        
        /// <summary>
        /// Variable value
        /// </summary>
        /// <value>Variable value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableStringDefaultValueRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as VariableStringDefaultValueRm);
        }

        /// <summary>
        /// Returns true if VariableStringDefaultValueRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableStringDefaultValueRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableStringDefaultValueRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
