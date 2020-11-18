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
    /// Record information model
    /// </summary>
    [DataContract]
        public partial class RecordInfoRm :  IEquatable<RecordInfoRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordInfoRm" /> class.
        /// </summary>
        /// <param name="creationDateUtc">Creation date.</param>
        /// <param name="lastEditDateUtc">Last edit date.</param>
        /// <param name="userCreator">userCreator (required).</param>
        /// <param name="userLastEditor">userLastEditor (required).</param>
        public RecordInfoRm(DateTime? creationDateUtc = default(DateTime?), DateTime? lastEditDateUtc = default(DateTime?), ArxivarUserInfoRm userCreator = default(ArxivarUserInfoRm), ArxivarUserInfoRm userLastEditor = default(ArxivarUserInfoRm))
        {
            // to ensure "userCreator" is required (not null)
            if (userCreator == null)
            {
                throw new InvalidDataException("userCreator is a required property for RecordInfoRm and cannot be null");
            }
            else
            {
                this.UserCreator = userCreator;
            }
            // to ensure "userLastEditor" is required (not null)
            if (userLastEditor == null)
            {
                throw new InvalidDataException("userLastEditor is a required property for RecordInfoRm and cannot be null");
            }
            else
            {
                this.UserLastEditor = userLastEditor;
            }
            this.CreationDateUtc = creationDateUtc;
            this.LastEditDateUtc = lastEditDateUtc;
        }
        
        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name="creationDateUtc", EmitDefaultValue=false)]
        public DateTime? CreationDateUtc { get; set; }

        /// <summary>
        /// Last edit date
        /// </summary>
        /// <value>Last edit date</value>
        [DataMember(Name="lastEditDateUtc", EmitDefaultValue=false)]
        public DateTime? LastEditDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets UserCreator
        /// </summary>
        [DataMember(Name="userCreator", EmitDefaultValue=false)]
        public ArxivarUserInfoRm UserCreator { get; set; }

        /// <summary>
        /// Gets or Sets UserLastEditor
        /// </summary>
        [DataMember(Name="userLastEditor", EmitDefaultValue=false)]
        public ArxivarUserInfoRm UserLastEditor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordInfoRm {\n");
            sb.Append("  CreationDateUtc: ").Append(CreationDateUtc).Append("\n");
            sb.Append("  LastEditDateUtc: ").Append(LastEditDateUtc).Append("\n");
            sb.Append("  UserCreator: ").Append(UserCreator).Append("\n");
            sb.Append("  UserLastEditor: ").Append(UserLastEditor).Append("\n");
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
            return this.Equals(input as RecordInfoRm);
        }

        /// <summary>
        /// Returns true if RecordInfoRm instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordInfoRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordInfoRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreationDateUtc == input.CreationDateUtc ||
                    (this.CreationDateUtc != null &&
                    this.CreationDateUtc.Equals(input.CreationDateUtc))
                ) && 
                (
                    this.LastEditDateUtc == input.LastEditDateUtc ||
                    (this.LastEditDateUtc != null &&
                    this.LastEditDateUtc.Equals(input.LastEditDateUtc))
                ) && 
                (
                    this.UserCreator == input.UserCreator ||
                    (this.UserCreator != null &&
                    this.UserCreator.Equals(input.UserCreator))
                ) && 
                (
                    this.UserLastEditor == input.UserLastEditor ||
                    (this.UserLastEditor != null &&
                    this.UserLastEditor.Equals(input.UserLastEditor))
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
                if (this.CreationDateUtc != null)
                    hashCode = hashCode * 59 + this.CreationDateUtc.GetHashCode();
                if (this.LastEditDateUtc != null)
                    hashCode = hashCode * 59 + this.LastEditDateUtc.GetHashCode();
                if (this.UserCreator != null)
                    hashCode = hashCode * 59 + this.UserCreator.GetHashCode();
                if (this.UserLastEditor != null)
                    hashCode = hashCode * 59 + this.UserLastEditor.GetHashCode();
                return hashCode;
            }
        }

    }
}
