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
    /// Formula test result
    /// </summary>
    [DataContract]
        public partial class FormuleTestResultRm :  IEquatable<FormuleTestResultRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormuleTestResultRm" /> class.
        /// </summary>
        /// <param name="success">Indicates if the evaluation was successful.</param>
        /// <param name="error">Error of the evaluation.</param>
        /// <param name="result">Evaluation result.</param>
        public FormuleTestResultRm(bool? success = default(bool?), string error = default(string), Object result = default(Object))
        {
            this.Success = success;
            this.Error = error;
            this.Result = result;
        }
        
        /// <summary>
        /// Indicates if the evaluation was successful
        /// </summary>
        /// <value>Indicates if the evaluation was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Error of the evaluation
        /// </summary>
        /// <value>Error of the evaluation</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Evaluation result
        /// </summary>
        /// <value>Evaluation result</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormuleTestResultRm {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as FormuleTestResultRm);
        }

        /// <summary>
        /// Returns true if FormuleTestResultRm instances are equal
        /// </summary>
        /// <param name="input">Instance of FormuleTestResultRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormuleTestResultRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }

    }
}
