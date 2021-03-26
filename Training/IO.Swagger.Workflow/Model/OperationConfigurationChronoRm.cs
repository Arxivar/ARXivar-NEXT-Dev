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
    /// OperationConfigurationChronoRm
    /// </summary>
    [DataContract]
        public partial class OperationConfigurationChronoRm : OperationsConfigurationRm,  IEquatable<OperationConfigurationChronoRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationConfigurationChronoRm" /> class.
        /// </summary>
        /// <param name="variableChrono">variableChrono (required).</param>
        /// <param name="mode">Chronometer set value mode [0&#x3D;Start, 1&#x3D;Stop, 2&#x3D;Reset].</param>
        public OperationConfigurationChronoRm(VariableInfoRm variableChrono = default(VariableInfoRm), int? mode = default(int?), int? operationType = default(int?), OperationRetryConfigurationRm retryConfiguration = default(OperationRetryConfigurationRm), EventInfoRm onErrorEventConfiguration = default(EventInfoRm), EventInfoRm onFailedEventConfiguration = default(EventInfoRm), bool? invalidateOtherOperations = default(bool?), string userDescription = default(string)) : base(operationType, retryConfiguration, onErrorEventConfiguration, onFailedEventConfiguration, invalidateOtherOperations, userDescription)
        {
            // to ensure "variableChrono" is required (not null)
            if (variableChrono == null)
            {
                throw new InvalidDataException("variableChrono is a required property for OperationConfigurationChronoRm and cannot be null");
            }
            else
            {
                this.VariableChrono = variableChrono;
            }
            this.Mode = mode;
        }
        
        /// <summary>
        /// Gets or Sets VariableChrono
        /// </summary>
        [DataMember(Name="variableChrono", EmitDefaultValue=false)]
        public VariableInfoRm VariableChrono { get; set; }

        /// <summary>
        /// Chronometer set value mode [0&#x3D;Start, 1&#x3D;Stop, 2&#x3D;Reset]
        /// </summary>
        /// <value>Chronometer set value mode [0&#x3D;Start, 1&#x3D;Stop, 2&#x3D;Reset]</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationConfigurationChronoRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  VariableChrono: ").Append(VariableChrono).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(input as OperationConfigurationChronoRm);
        }

        /// <summary>
        /// Returns true if OperationConfigurationChronoRm instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationConfigurationChronoRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationConfigurationChronoRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.VariableChrono == input.VariableChrono ||
                    (this.VariableChrono != null &&
                    this.VariableChrono.Equals(input.VariableChrono))
                ) && base.Equals(input) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.VariableChrono != null)
                    hashCode = hashCode * 59 + this.VariableChrono.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }

    }
}
