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
    /// IMAP Folders configuration
    /// </summary>
    [DataContract]
    public partial class MailAccountImapFolderDTO :  IEquatable<MailAccountImapFolderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountImapFolderDTO" /> class.
        /// </summary>
        /// <param name="sourceFolder">Source folder.</param>
        /// <param name="destinationFolder">Destination folder.</param>
        /// <param name="afterDownloadAction">Possible values:  0: None  1: DeleteMessage  2: MoveToDestinationFolder .</param>
        /// <param name="pecSubject">Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite .</param>
        /// <param name="pecSender">Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite .</param>
        /// <param name="peekMode">Boolean indicating whether to leave the email as unread.</param>
        /// <param name="mapping">Fields mapping.</param>
        public MailAccountImapFolderDTO(string sourceFolder = default(string), string destinationFolder = default(string), int? afterDownloadAction = default(int?), int? pecSubject = default(int?), int? pecSender = default(int?), bool? peekMode = default(bool?), MailAccountStoreSettingsDTO mapping = default(MailAccountStoreSettingsDTO))
        {
            this.SourceFolder = sourceFolder;
            this.DestinationFolder = destinationFolder;
            this.AfterDownloadAction = afterDownloadAction;
            this.PecSubject = pecSubject;
            this.PecSender = pecSender;
            this.PeekMode = peekMode;
            this.Mapping = mapping;
        }
        
        /// <summary>
        /// Source folder
        /// </summary>
        /// <value>Source folder</value>
        [DataMember(Name="sourceFolder", EmitDefaultValue=false)]
        public string SourceFolder { get; set; }

        /// <summary>
        /// Destination folder
        /// </summary>
        /// <value>Destination folder</value>
        [DataMember(Name="destinationFolder", EmitDefaultValue=false)]
        public string DestinationFolder { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: DeleteMessage  2: MoveToDestinationFolder 
        /// </summary>
        /// <value>Possible values:  0: None  1: DeleteMessage  2: MoveToDestinationFolder </value>
        [DataMember(Name="afterDownloadAction", EmitDefaultValue=false)]
        public int? AfterDownloadAction { get; set; }

        /// <summary>
        /// Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite 
        /// </summary>
        /// <value>Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite </value>
        [DataMember(Name="pecSubject", EmitDefaultValue=false)]
        public int? PecSubject { get; set; }

        /// <summary>
        /// Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite 
        /// </summary>
        /// <value>Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite </value>
        [DataMember(Name="pecSender", EmitDefaultValue=false)]
        public int? PecSender { get; set; }

        /// <summary>
        /// Boolean indicating whether to leave the email as unread
        /// </summary>
        /// <value>Boolean indicating whether to leave the email as unread</value>
        [DataMember(Name="peekMode", EmitDefaultValue=false)]
        public bool? PeekMode { get; set; }

        /// <summary>
        /// Fields mapping
        /// </summary>
        /// <value>Fields mapping</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public MailAccountStoreSettingsDTO Mapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountImapFolderDTO {\n");
            sb.Append("  SourceFolder: ").Append(SourceFolder).Append("\n");
            sb.Append("  DestinationFolder: ").Append(DestinationFolder).Append("\n");
            sb.Append("  AfterDownloadAction: ").Append(AfterDownloadAction).Append("\n");
            sb.Append("  PecSubject: ").Append(PecSubject).Append("\n");
            sb.Append("  PecSender: ").Append(PecSender).Append("\n");
            sb.Append("  PeekMode: ").Append(PeekMode).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(input as MailAccountImapFolderDTO);
        }

        /// <summary>
        /// Returns true if MailAccountImapFolderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountImapFolderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountImapFolderDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceFolder == input.SourceFolder ||
                    (this.SourceFolder != null &&
                    this.SourceFolder.Equals(input.SourceFolder))
                ) && 
                (
                    this.DestinationFolder == input.DestinationFolder ||
                    (this.DestinationFolder != null &&
                    this.DestinationFolder.Equals(input.DestinationFolder))
                ) && 
                (
                    this.AfterDownloadAction == input.AfterDownloadAction ||
                    (this.AfterDownloadAction != null &&
                    this.AfterDownloadAction.Equals(input.AfterDownloadAction))
                ) && 
                (
                    this.PecSubject == input.PecSubject ||
                    (this.PecSubject != null &&
                    this.PecSubject.Equals(input.PecSubject))
                ) && 
                (
                    this.PecSender == input.PecSender ||
                    (this.PecSender != null &&
                    this.PecSender.Equals(input.PecSender))
                ) && 
                (
                    this.PeekMode == input.PeekMode ||
                    (this.PeekMode != null &&
                    this.PeekMode.Equals(input.PeekMode))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
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
                if (this.SourceFolder != null)
                    hashCode = hashCode * 59 + this.SourceFolder.GetHashCode();
                if (this.DestinationFolder != null)
                    hashCode = hashCode * 59 + this.DestinationFolder.GetHashCode();
                if (this.AfterDownloadAction != null)
                    hashCode = hashCode * 59 + this.AfterDownloadAction.GetHashCode();
                if (this.PecSubject != null)
                    hashCode = hashCode * 59 + this.PecSubject.GetHashCode();
                if (this.PecSender != null)
                    hashCode = hashCode * 59 + this.PecSender.GetHashCode();
                if (this.PeekMode != null)
                    hashCode = hashCode * 59 + this.PeekMode.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
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