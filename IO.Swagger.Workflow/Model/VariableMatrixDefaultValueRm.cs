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
    /// VariableMatrixDefaultValueRm
    /// </summary>
    [DataContract]
        public partial class VariableMatrixDefaultValueRm : VariableDefaultValueRm,  IEquatable<VariableMatrixDefaultValueRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableMatrixDefaultValueRm" /> class.
        /// </summary>
        /// <param name="values">Variable Value.</param>
        public VariableMatrixDefaultValueRm(List<Object> values = default(List<Object>), int? variableType = default(int?)) : base(variableType)
        {
            this.Values = values;
        }
        
        /// <summary>
        /// Variable Value
        /// </summary>
        /// <value>Variable Value</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableMatrixDefaultValueRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as VariableMatrixDefaultValueRm);
        }

        /// <summary>
        /// Returns true if VariableMatrixDefaultValueRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableMatrixDefaultValueRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableMatrixDefaultValueRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }

    }
}
