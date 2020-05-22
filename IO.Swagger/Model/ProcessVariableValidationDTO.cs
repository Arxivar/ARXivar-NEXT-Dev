/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Class for process validation
    /// </summary>
    [DataContract]
    public partial class ProcessVariableValidationDTO :  IEquatable<ProcessVariableValidationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessVariableValidationDTO" /> class.
        /// </summary>
        /// <param name="variableName">The variable the must be validated.</param>
        /// <param name="currentData">The complete list of the process variables.</param>
        public ProcessVariableValidationDTO(string variableName = default(string), ProcessVariablesFieldsDTO currentData = default(ProcessVariablesFieldsDTO))
        {
            this.VariableName = variableName;
            this.CurrentData = currentData;
        }
        
        /// <summary>
        /// The variable the must be validated
        /// </summary>
        /// <value>The variable the must be validated</value>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// The complete list of the process variables
        /// </summary>
        /// <value>The complete list of the process variables</value>
        [DataMember(Name="currentData", EmitDefaultValue=false)]
        public ProcessVariablesFieldsDTO CurrentData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessVariableValidationDTO {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  CurrentData: ").Append(CurrentData).Append("\n");
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
            return this.Equals(input as ProcessVariableValidationDTO);
        }

        /// <summary>
        /// Returns true if ProcessVariableValidationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessVariableValidationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessVariableValidationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.CurrentData == input.CurrentData ||
                    (this.CurrentData != null &&
                    this.CurrentData.Equals(input.CurrentData))
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.CurrentData != null)
                    hashCode = hashCode * 59 + this.CurrentData.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
