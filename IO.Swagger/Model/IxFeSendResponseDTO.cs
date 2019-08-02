/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    /// IxFe Send response
    /// </summary>
    [DataContract]
    public partial class IxFeSendResponseDTO :  IEquatable<IxFeSendResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeSendResponseDTO" /> class.
        /// </summary>
        /// <param name="signCert">Signature Certificate.</param>
        /// <param name="sendRequestId">Identifier of asynchronous activity (QueueId).</param>
        public IxFeSendResponseDTO(SignCertDTO signCert = default(SignCertDTO), string sendRequestId = default(string))
        {
            this.SignCert = signCert;
            this.SendRequestId = sendRequestId;
        }
        
        /// <summary>
        /// Signature Certificate
        /// </summary>
        /// <value>Signature Certificate</value>
        [DataMember(Name="signCert", EmitDefaultValue=false)]
        public SignCertDTO SignCert { get; set; }

        /// <summary>
        /// Identifier of asynchronous activity (QueueId)
        /// </summary>
        /// <value>Identifier of asynchronous activity (QueueId)</value>
        [DataMember(Name="sendRequestId", EmitDefaultValue=false)]
        public string SendRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeSendResponseDTO {\n");
            sb.Append("  SignCert: ").Append(SignCert).Append("\n");
            sb.Append("  SendRequestId: ").Append(SendRequestId).Append("\n");
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
            return this.Equals(input as IxFeSendResponseDTO);
        }

        /// <summary>
        /// Returns true if IxFeSendResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeSendResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeSendResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignCert == input.SignCert ||
                    (this.SignCert != null &&
                    this.SignCert.Equals(input.SignCert))
                ) && 
                (
                    this.SendRequestId == input.SendRequestId ||
                    (this.SendRequestId != null &&
                    this.SendRequestId.Equals(input.SendRequestId))
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
                if (this.SignCert != null)
                    hashCode = hashCode * 59 + this.SignCert.GetHashCode();
                if (this.SendRequestId != null)
                    hashCode = hashCode * 59 + this.SendRequestId.GetHashCode();
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