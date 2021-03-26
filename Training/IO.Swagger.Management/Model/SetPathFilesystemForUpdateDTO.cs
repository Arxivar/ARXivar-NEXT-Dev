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
    /// Filesystem parameters for update
    /// </summary>
    [DataContract]
    public partial class SetPathFilesystemForUpdateDTO :  IEquatable<SetPathFilesystemForUpdateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPathFilesystemForUpdateDTO" /> class.
        /// </summary>
        /// <param name="path">Directory path.</param>
        /// <param name="newPath">New directory path.</param>
        public SetPathFilesystemForUpdateDTO(string path = default(string), string newPath = default(string))
        {
            this.Path = path;
            this.NewPath = newPath;
        }
        
        /// <summary>
        /// Directory path
        /// </summary>
        /// <value>Directory path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// New directory path
        /// </summary>
        /// <value>New directory path</value>
        [DataMember(Name="newPath", EmitDefaultValue=false)]
        public string NewPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPathFilesystemForUpdateDTO {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  NewPath: ").Append(NewPath).Append("\n");
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
            return this.Equals(input as SetPathFilesystemForUpdateDTO);
        }

        /// <summary>
        /// Returns true if SetPathFilesystemForUpdateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPathFilesystemForUpdateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPathFilesystemForUpdateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.NewPath == input.NewPath ||
                    (this.NewPath != null &&
                    this.NewPath.Equals(input.NewPath))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.NewPath != null)
                    hashCode = hashCode * 59 + this.NewPath.GetHashCode();
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
