/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class for set Secure Storage Settings
    /// </summary>
    [DataContract]
    public partial class SecureStorageSettingsDTO :  IEquatable<SecureStorageSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureStorageSettingsDTO" /> class.
        /// </summary>
        /// <param name="oldPassword">Secure storage old password. Required only for password update.</param>
        /// <param name="password">Secure storage new password.</param>
        public SecureStorageSettingsDTO(string oldPassword = default(string), string password = default(string))
        {
            this.OldPassword = oldPassword;
            this.Password = password;
        }
        
        /// <summary>
        /// Secure storage old password. Required only for password update
        /// </summary>
        /// <value>Secure storage old password. Required only for password update</value>
        [DataMember(Name="oldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Secure storage new password
        /// </summary>
        /// <value>Secure storage new password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecureStorageSettingsDTO {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as SecureStorageSettingsDTO);
        }

        /// <summary>
        /// Returns true if SecureStorageSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecureStorageSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecureStorageSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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