/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AttachmentDTO
    /// </summary>
    [DataContract]
    public partial class AttachmentDTO :  IEquatable<AttachmentDTO>
    {
        /// <summary>
        /// Storage Device type for the attachment compressed file
        /// </summary>
        /// <value>Storage Device type for the attachment compressed file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceEnum
        {
            
            /// <summary>
            /// Enum Hd for "Hd"
            /// </summary>
            [EnumMember(Value = "Hd")]
            Hd,
            
            /// <summary>
            /// Enum Cd for "Cd"
            /// </summary>
            [EnumMember(Value = "Cd")]
            Cd
        }

        /// <summary>
        /// Lock type for the attachment.
        /// </summary>
        /// <value>Lock type for the attachment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Marked for "Marked"
            /// </summary>
            [EnumMember(Value = "Marked")]
            Marked
        }

        /// <summary>
        /// Attachment access level.
        /// </summary>
        /// <value>Attachment access level.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum AccessDenied for "Access_Denied"
            /// </summary>
            [EnumMember(Value = "Access_Denied")]
            AccessDenied,
            
            /// <summary>
            /// Enum ReadOnly for "Read_Only"
            /// </summary>
            [EnumMember(Value = "Read_Only")]
            ReadOnly,
            
            /// <summary>
            /// Enum Edit for "Edit"
            /// </summary>
            [EnumMember(Value = "Edit")]
            Edit,
            
            /// <summary>
            /// Enum FullTrust for "Full_Trust"
            /// </summary>
            [EnumMember(Value = "Full_Trust")]
            FullTrust
        }

        /// <summary>
        /// Save type.
        /// </summary>
        /// <value>Save type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SaveTypeEnum
        {
            
            /// <summary>
            /// Enum FileSystem for "File_System"
            /// </summary>
            [EnumMember(Value = "File_System")]
            FileSystem,
            
            /// <summary>
            /// Enum Database for "Database"
            /// </summary>
            [EnumMember(Value = "Database")]
            Database
        }

        /// <summary>
        /// Attachment type
        /// </summary>
        /// <value>Attachment type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            
            /// <summary>
            /// Enum ExternalAttachement for "ExternalAttachement"
            /// </summary>
            [EnumMember(Value = "ExternalAttachement")]
            ExternalAttachement,
            
            /// <summary>
            /// Enum InternalAttachement for "InternalAttachement"
            /// </summary>
            [EnumMember(Value = "InternalAttachement")]
            InternalAttachement
        }

        /// <summary>
        /// Type of the compression
        /// </summary>
        /// <value>Type of the compression</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionModeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum CompressChilkat91 for "CompressChilkat91"
            /// </summary>
            [EnumMember(Value = "CompressChilkat91")]
            CompressChilkat91,
            
            /// <summary>
            /// Enum CompressChilkat95 for "CompressChilkat95"
            /// </summary>
            [EnumMember(Value = "CompressChilkat95")]
            CompressChilkat95,
            
            /// <summary>
            /// Enum CompressChilkat95AndCryptoAes256 for "CompressChilkat95AndCryptoAes256"
            /// </summary>
            [EnumMember(Value = "CompressChilkat95AndCryptoAes256")]
            CompressChilkat95AndCryptoAes256
        }

        /// <summary>
        /// Storage Device type for the attachment compressed file
        /// </summary>
        /// <value>Storage Device type for the attachment compressed file</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public DeviceEnum? Device { get; set; }
        /// <summary>
        /// Lock type for the attachment.
        /// </summary>
        /// <value>Lock type for the attachment.</value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public BlockEnum? Block { get; set; }
        /// <summary>
        /// Attachment access level.
        /// </summary>
        /// <value>Attachment access level.</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// Save type.
        /// </summary>
        /// <value>Save type.</value>
        [DataMember(Name="saveType", EmitDefaultValue=false)]
        public SaveTypeEnum? SaveType { get; set; }
        /// <summary>
        /// Attachment type
        /// </summary>
        /// <value>Attachment type</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Type of the compression
        /// </summary>
        /// <value>Type of the compression</value>
        [DataMember(Name="compressionMode", EmitDefaultValue=false)]
        public CompressionModeEnum? CompressionMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentDTO" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier of the attachments.</param>
        /// <param name="Docnumber">Unique docnumber of the profile..</param>
        /// <param name="Revision">Revision number for the profile..</param>
        /// <param name="Filename">Name for the zip file..</param>
        /// <param name="Filepath">Path of compressed file..</param>
        /// <param name="Originalname">Name of the file..</param>
        /// <param name="Device">Storage Device type for the attachment compressed file.</param>
        /// <param name="Cdlabel">Label of the CD (if CD is the storage device type of this attachment)..</param>
        /// <param name="Comment">Attachments description..</param>
        /// <param name="Importdate">Date of the attachment creation..</param>
        /// <param name="User">UserId of the author..</param>
        /// <param name="UserCompleteName">Complete name of the author..</param>
        /// <param name="Block">Lock type for the attachment..</param>
        /// <param name="Compliantcopy">Indicates if this attachment replace profile for web visualization..</param>
        /// <param name="Footprint">Hash for the file..</param>
        /// <param name="Checksend">Occurs if the attachment must be submitted with the main document in the case of shipment..</param>
        /// <param name="Aosflag">Occurs if the attachment must be kept in the replacement mode with the document profile..</param>
        /// <param name="Access">Attachment access level..</param>
        /// <param name="SaveType">Save type..</param>
        /// <param name="Filesize">File size in bytes..</param>
        /// <param name="Kind">Attachment type.</param>
        /// <param name="AttachedDocnumber">Profile of this attachment.</param>
        /// <param name="IxCheck">Occurs if the attachment must be sent to IX along with the main document in the case of shipment..</param>
        /// <param name="AttachmentRevision">Indicates the revision of attachment.</param>
        /// <param name="CompressionMode">Type of the compression.</param>
        public AttachmentDTO(int? Id = null, int? Docnumber = null, int? Revision = null, string Filename = null, string Filepath = null, string Originalname = null, DeviceEnum? Device = null, string Cdlabel = null, string Comment = null, DateTime? Importdate = null, int? User = null, string UserCompleteName = null, BlockEnum? Block = null, bool? Compliantcopy = null, string Footprint = null, bool? Checksend = null, bool? Aosflag = null, AccessEnum? Access = null, SaveTypeEnum? SaveType = null, long? Filesize = null, KindEnum? Kind = null, int? AttachedDocnumber = null, bool? IxCheck = null, int? AttachmentRevision = null, CompressionModeEnum? CompressionMode = null)
        {
            this.Id = Id;
            this.Docnumber = Docnumber;
            this.Revision = Revision;
            this.Filename = Filename;
            this.Filepath = Filepath;
            this.Originalname = Originalname;
            this.Device = Device;
            this.Cdlabel = Cdlabel;
            this.Comment = Comment;
            this.Importdate = Importdate;
            this.User = User;
            this.UserCompleteName = UserCompleteName;
            this.Block = Block;
            this.Compliantcopy = Compliantcopy;
            this.Footprint = Footprint;
            this.Checksend = Checksend;
            this.Aosflag = Aosflag;
            this.Access = Access;
            this.SaveType = SaveType;
            this.Filesize = Filesize;
            this.Kind = Kind;
            this.AttachedDocnumber = AttachedDocnumber;
            this.IxCheck = IxCheck;
            this.AttachmentRevision = AttachmentRevision;
            this.CompressionMode = CompressionMode;
        }
        
        /// <summary>
        /// Unique identifier of the attachments
        /// </summary>
        /// <value>Unique identifier of the attachments</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Unique docnumber of the profile.
        /// </summary>
        /// <value>Unique docnumber of the profile.</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }
        /// <summary>
        /// Revision number for the profile.
        /// </summary>
        /// <value>Revision number for the profile.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }
        /// <summary>
        /// Name for the zip file.
        /// </summary>
        /// <value>Name for the zip file.</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
        /// <summary>
        /// Path of compressed file.
        /// </summary>
        /// <value>Path of compressed file.</value>
        [DataMember(Name="filepath", EmitDefaultValue=false)]
        public string Filepath { get; set; }
        /// <summary>
        /// Name of the file.
        /// </summary>
        /// <value>Name of the file.</value>
        [DataMember(Name="originalname", EmitDefaultValue=false)]
        public string Originalname { get; set; }
        /// <summary>
        /// Label of the CD (if CD is the storage device type of this attachment).
        /// </summary>
        /// <value>Label of the CD (if CD is the storage device type of this attachment).</value>
        [DataMember(Name="cdlabel", EmitDefaultValue=false)]
        public string Cdlabel { get; set; }
        /// <summary>
        /// Attachments description.
        /// </summary>
        /// <value>Attachments description.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Date of the attachment creation.
        /// </summary>
        /// <value>Date of the attachment creation.</value>
        [DataMember(Name="importdate", EmitDefaultValue=false)]
        public DateTime? Importdate { get; set; }
        /// <summary>
        /// UserId of the author.
        /// </summary>
        /// <value>UserId of the author.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
        /// <summary>
        /// Complete name of the author.
        /// </summary>
        /// <value>Complete name of the author.</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }
        /// <summary>
        /// Indicates if this attachment replace profile for web visualization.
        /// </summary>
        /// <value>Indicates if this attachment replace profile for web visualization.</value>
        [DataMember(Name="compliantcopy", EmitDefaultValue=false)]
        public bool? Compliantcopy { get; set; }
        /// <summary>
        /// Hash for the file.
        /// </summary>
        /// <value>Hash for the file.</value>
        [DataMember(Name="footprint", EmitDefaultValue=false)]
        public string Footprint { get; set; }
        /// <summary>
        /// Occurs if the attachment must be submitted with the main document in the case of shipment.
        /// </summary>
        /// <value>Occurs if the attachment must be submitted with the main document in the case of shipment.</value>
        [DataMember(Name="checksend", EmitDefaultValue=false)]
        public bool? Checksend { get; set; }
        /// <summary>
        /// Occurs if the attachment must be kept in the replacement mode with the document profile.
        /// </summary>
        /// <value>Occurs if the attachment must be kept in the replacement mode with the document profile.</value>
        [DataMember(Name="aosflag", EmitDefaultValue=false)]
        public bool? Aosflag { get; set; }
        /// <summary>
        /// File size in bytes.
        /// </summary>
        /// <value>File size in bytes.</value>
        [DataMember(Name="filesize", EmitDefaultValue=false)]
        public long? Filesize { get; set; }
        /// <summary>
        /// Profile of this attachment
        /// </summary>
        /// <value>Profile of this attachment</value>
        [DataMember(Name="attachedDocnumber", EmitDefaultValue=false)]
        public int? AttachedDocnumber { get; set; }
        /// <summary>
        /// Occurs if the attachment must be sent to IX along with the main document in the case of shipment.
        /// </summary>
        /// <value>Occurs if the attachment must be sent to IX along with the main document in the case of shipment.</value>
        [DataMember(Name="ixCheck", EmitDefaultValue=false)]
        public bool? IxCheck { get; set; }
        /// <summary>
        /// Indicates the revision of attachment
        /// </summary>
        /// <value>Indicates the revision of attachment</value>
        [DataMember(Name="attachmentRevision", EmitDefaultValue=false)]
        public int? AttachmentRevision { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Filepath: ").Append(Filepath).Append("\n");
            sb.Append("  Originalname: ").Append(Originalname).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Cdlabel: ").Append(Cdlabel).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Importdate: ").Append(Importdate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Compliantcopy: ").Append(Compliantcopy).Append("\n");
            sb.Append("  Footprint: ").Append(Footprint).Append("\n");
            sb.Append("  Checksend: ").Append(Checksend).Append("\n");
            sb.Append("  Aosflag: ").Append(Aosflag).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SaveType: ").Append(SaveType).Append("\n");
            sb.Append("  Filesize: ").Append(Filesize).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  AttachedDocnumber: ").Append(AttachedDocnumber).Append("\n");
            sb.Append("  IxCheck: ").Append(IxCheck).Append("\n");
            sb.Append("  AttachmentRevision: ").Append(AttachmentRevision).Append("\n");
            sb.Append("  CompressionMode: ").Append(CompressionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AttachmentDTO);
        }

        /// <summary>
        /// Returns true if AttachmentDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Docnumber == other.Docnumber ||
                    this.Docnumber != null &&
                    this.Docnumber.Equals(other.Docnumber)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) && 
                (
                    this.Filepath == other.Filepath ||
                    this.Filepath != null &&
                    this.Filepath.Equals(other.Filepath)
                ) && 
                (
                    this.Originalname == other.Originalname ||
                    this.Originalname != null &&
                    this.Originalname.Equals(other.Originalname)
                ) && 
                (
                    this.Device == other.Device ||
                    this.Device != null &&
                    this.Device.Equals(other.Device)
                ) && 
                (
                    this.Cdlabel == other.Cdlabel ||
                    this.Cdlabel != null &&
                    this.Cdlabel.Equals(other.Cdlabel)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Importdate == other.Importdate ||
                    this.Importdate != null &&
                    this.Importdate.Equals(other.Importdate)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.UserCompleteName == other.UserCompleteName ||
                    this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(other.UserCompleteName)
                ) && 
                (
                    this.Block == other.Block ||
                    this.Block != null &&
                    this.Block.Equals(other.Block)
                ) && 
                (
                    this.Compliantcopy == other.Compliantcopy ||
                    this.Compliantcopy != null &&
                    this.Compliantcopy.Equals(other.Compliantcopy)
                ) && 
                (
                    this.Footprint == other.Footprint ||
                    this.Footprint != null &&
                    this.Footprint.Equals(other.Footprint)
                ) && 
                (
                    this.Checksend == other.Checksend ||
                    this.Checksend != null &&
                    this.Checksend.Equals(other.Checksend)
                ) && 
                (
                    this.Aosflag == other.Aosflag ||
                    this.Aosflag != null &&
                    this.Aosflag.Equals(other.Aosflag)
                ) && 
                (
                    this.Access == other.Access ||
                    this.Access != null &&
                    this.Access.Equals(other.Access)
                ) && 
                (
                    this.SaveType == other.SaveType ||
                    this.SaveType != null &&
                    this.SaveType.Equals(other.SaveType)
                ) && 
                (
                    this.Filesize == other.Filesize ||
                    this.Filesize != null &&
                    this.Filesize.Equals(other.Filesize)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.AttachedDocnumber == other.AttachedDocnumber ||
                    this.AttachedDocnumber != null &&
                    this.AttachedDocnumber.Equals(other.AttachedDocnumber)
                ) && 
                (
                    this.IxCheck == other.IxCheck ||
                    this.IxCheck != null &&
                    this.IxCheck.Equals(other.IxCheck)
                ) && 
                (
                    this.AttachmentRevision == other.AttachmentRevision ||
                    this.AttachmentRevision != null &&
                    this.AttachmentRevision.Equals(other.AttachmentRevision)
                ) && 
                (
                    this.CompressionMode == other.CompressionMode ||
                    this.CompressionMode != null &&
                    this.CompressionMode.Equals(other.CompressionMode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Docnumber != null)
                    hash = hash * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.Filepath != null)
                    hash = hash * 59 + this.Filepath.GetHashCode();
                if (this.Originalname != null)
                    hash = hash * 59 + this.Originalname.GetHashCode();
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                if (this.Cdlabel != null)
                    hash = hash * 59 + this.Cdlabel.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Importdate != null)
                    hash = hash * 59 + this.Importdate.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.UserCompleteName != null)
                    hash = hash * 59 + this.UserCompleteName.GetHashCode();
                if (this.Block != null)
                    hash = hash * 59 + this.Block.GetHashCode();
                if (this.Compliantcopy != null)
                    hash = hash * 59 + this.Compliantcopy.GetHashCode();
                if (this.Footprint != null)
                    hash = hash * 59 + this.Footprint.GetHashCode();
                if (this.Checksend != null)
                    hash = hash * 59 + this.Checksend.GetHashCode();
                if (this.Aosflag != null)
                    hash = hash * 59 + this.Aosflag.GetHashCode();
                if (this.Access != null)
                    hash = hash * 59 + this.Access.GetHashCode();
                if (this.SaveType != null)
                    hash = hash * 59 + this.SaveType.GetHashCode();
                if (this.Filesize != null)
                    hash = hash * 59 + this.Filesize.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.AttachedDocnumber != null)
                    hash = hash * 59 + this.AttachedDocnumber.GetHashCode();
                if (this.IxCheck != null)
                    hash = hash * 59 + this.IxCheck.GetHashCode();
                if (this.AttachmentRevision != null)
                    hash = hash * 59 + this.AttachmentRevision.GetHashCode();
                if (this.CompressionMode != null)
                    hash = hash * 59 + this.CompressionMode.GetHashCode();
                return hash;
            }
        }
    }

}
