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
    /// VariableChronoConfigurationRm
    /// </summary>
    [DataContract]
        public partial class VariableChronoConfigurationRm : VariabileConfigurationRm,  IEquatable<VariableChronoConfigurationRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableChronoConfigurationRm" /> class.
        /// </summary>
        /// <param name="managePartials">Indicates if the chrono manages partials.</param>
        /// <param name="activateIntervalExpirationCheck">Indicates if the timer must throw an event if the expected duration is exceeded.</param>
        /// <param name="expirationEvent">expirationEvent.</param>
        /// <param name="expirationInterval">expirationInterval.</param>
        public VariableChronoConfigurationRm(bool? managePartials = default(bool?), bool? activateIntervalExpirationCheck = default(bool?), EventInfoRm expirationEvent = default(EventInfoRm), ObjectIntervalConfigurationRm expirationInterval = default(ObjectIntervalConfigurationRm), int? variableType = default(int?), string name = default(string), bool? encryption = default(bool?), List<MultiLanguageValueRm> labels = default(List<MultiLanguageValueRm>), List<MultiLanguageValueRm> descriptions = default(List<MultiLanguageValueRm>), int? validationType = default(int?), string validationString = default(string), List<MultiLanguageValueRm> validationErrors = default(List<MultiLanguageValueRm>)) : base(variableType, name, encryption, labels, descriptions, validationType, validationString, validationErrors)
        {
            this.ManagePartials = managePartials;
            this.ActivateIntervalExpirationCheck = activateIntervalExpirationCheck;
            this.ExpirationEvent = expirationEvent;
            this.ExpirationInterval = expirationInterval;
        }
        
        /// <summary>
        /// Indicates if the chrono manages partials
        /// </summary>
        /// <value>Indicates if the chrono manages partials</value>
        [DataMember(Name="managePartials", EmitDefaultValue=false)]
        public bool? ManagePartials { get; set; }

        /// <summary>
        /// Indicates if the timer must throw an event if the expected duration is exceeded
        /// </summary>
        /// <value>Indicates if the timer must throw an event if the expected duration is exceeded</value>
        [DataMember(Name="activateIntervalExpirationCheck", EmitDefaultValue=false)]
        public bool? ActivateIntervalExpirationCheck { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationEvent
        /// </summary>
        [DataMember(Name="expirationEvent", EmitDefaultValue=false)]
        public EventInfoRm ExpirationEvent { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationInterval
        /// </summary>
        [DataMember(Name="expirationInterval", EmitDefaultValue=false)]
        public ObjectIntervalConfigurationRm ExpirationInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableChronoConfigurationRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ManagePartials: ").Append(ManagePartials).Append("\n");
            sb.Append("  ActivateIntervalExpirationCheck: ").Append(ActivateIntervalExpirationCheck).Append("\n");
            sb.Append("  ExpirationEvent: ").Append(ExpirationEvent).Append("\n");
            sb.Append("  ExpirationInterval: ").Append(ExpirationInterval).Append("\n");
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
            return this.Equals(input as VariableChronoConfigurationRm);
        }

        /// <summary>
        /// Returns true if VariableChronoConfigurationRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableChronoConfigurationRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableChronoConfigurationRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ManagePartials == input.ManagePartials ||
                    (this.ManagePartials != null &&
                    this.ManagePartials.Equals(input.ManagePartials))
                ) && base.Equals(input) && 
                (
                    this.ActivateIntervalExpirationCheck == input.ActivateIntervalExpirationCheck ||
                    (this.ActivateIntervalExpirationCheck != null &&
                    this.ActivateIntervalExpirationCheck.Equals(input.ActivateIntervalExpirationCheck))
                ) && base.Equals(input) && 
                (
                    this.ExpirationEvent == input.ExpirationEvent ||
                    (this.ExpirationEvent != null &&
                    this.ExpirationEvent.Equals(input.ExpirationEvent))
                ) && base.Equals(input) && 
                (
                    this.ExpirationInterval == input.ExpirationInterval ||
                    (this.ExpirationInterval != null &&
                    this.ExpirationInterval.Equals(input.ExpirationInterval))
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
                if (this.ManagePartials != null)
                    hashCode = hashCode * 59 + this.ManagePartials.GetHashCode();
                if (this.ActivateIntervalExpirationCheck != null)
                    hashCode = hashCode * 59 + this.ActivateIntervalExpirationCheck.GetHashCode();
                if (this.ExpirationEvent != null)
                    hashCode = hashCode * 59 + this.ExpirationEvent.GetHashCode();
                if (this.ExpirationInterval != null)
                    hashCode = hashCode * 59 + this.ExpirationInterval.GetHashCode();
                return hashCode;
            }
        }

    }
}
