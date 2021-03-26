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
    /// Process external parameter to associate to a variable
    /// </summary>
    [DataContract]
        public partial class ProcessExternalParameterRm :  IEquatable<ProcessExternalParameterRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessExternalParameterRm" /> class.
        /// </summary>
        /// <param name="srcVariable">srcVariable.</param>
        /// <param name="value">Variable value.</param>
        public ProcessExternalParameterRm(VariableInfoRm srcVariable = default(VariableInfoRm), Object value = default(Object))
        {
            this.SrcVariable = srcVariable;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets SrcVariable
        /// </summary>
        [DataMember(Name="srcVariable", EmitDefaultValue=false)]
        public VariableInfoRm SrcVariable { get; set; }

        /// <summary>
        /// Variable value
        /// </summary>
        /// <value>Variable value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessExternalParameterRm {\n");
            sb.Append("  SrcVariable: ").Append(SrcVariable).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ProcessExternalParameterRm);
        }

        /// <summary>
        /// Returns true if ProcessExternalParameterRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessExternalParameterRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessExternalParameterRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SrcVariable == input.SrcVariable ||
                    (this.SrcVariable != null &&
                    this.SrcVariable.Equals(input.SrcVariable))
                ) && 
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
                int hashCode = 41;
                if (this.SrcVariable != null)
                    hashCode = hashCode * 59 + this.SrcVariable.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}