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
    /// SharingReceiverUriDTO
    /// </summary>
    [DataContract]
    public partial class SharingReceiverUriDTO :  IEquatable<SharingReceiverUriDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingReceiverUriDTO" /> class.
        /// </summary>
        /// <param name="receiverId">Receiver unique id..</param>
        /// <param name="url">Url address for sharing..</param>
        public SharingReceiverUriDTO(string receiverId = default(string), string url = default(string))
        {
            this.ReceiverId = receiverId;
            this.Url = url;
        }
        
        /// <summary>
        /// Receiver unique id.
        /// </summary>
        /// <value>Receiver unique id.</value>
        [DataMember(Name="receiverId", EmitDefaultValue=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// Url address for sharing.
        /// </summary>
        /// <value>Url address for sharing.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingReceiverUriDTO {\n");
            sb.Append("  ReceiverId: ").Append(ReceiverId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as SharingReceiverUriDTO);
        }

        /// <summary>
        /// Returns true if SharingReceiverUriDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingReceiverUriDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingReceiverUriDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReceiverId == input.ReceiverId ||
                    (this.ReceiverId != null &&
                    this.ReceiverId.Equals(input.ReceiverId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.ReceiverId != null)
                    hashCode = hashCode * 59 + this.ReceiverId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
