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
    /// Document operation DTO.
    /// </summary>
    [DataContract]
    public partial class TaskWorkDocumentOperationDTO :  IEquatable<TaskWorkDocumentOperationDTO>
    {
        /// <summary>
        /// Document type.
        /// </summary>
        /// <value>Document type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaskWorkDocumentOperationTypeEnum
        {
            
            /// <summary>
            /// Enum Attachment for "Attachment"
            /// </summary>
            [EnumMember(Value = "Attachment")]
            Attachment,
            
            /// <summary>
            /// Enum PrincipalDocument for "PrincipalDocument"
            /// </summary>
            [EnumMember(Value = "PrincipalDocument")]
            PrincipalDocument,
            
            /// <summary>
            /// Enum SecondaryDocument for "SecondaryDocument"
            /// </summary>
            [EnumMember(Value = "SecondaryDocument")]
            SecondaryDocument
        }

        /// <summary>
        /// Relation modality
        /// </summary>
        /// <value>Relation modality</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaskWorkDocumentOperationRealtionModeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum AsChild for "AsChild"
            /// </summary>
            [EnumMember(Value = "AsChild")]
            AsChild,
            
            /// <summary>
            /// Enum AsFather for "AsFather"
            /// </summary>
            [EnumMember(Value = "AsFather")]
            AsFather
        }

        /// <summary>
        /// Document type.
        /// </summary>
        /// <value>Document type.</value>
        [DataMember(Name="taskWorkDocumentOperationType", EmitDefaultValue=false)]
        public TaskWorkDocumentOperationTypeEnum? TaskWorkDocumentOperationType { get; set; }
        /// <summary>
        /// Relation modality
        /// </summary>
        /// <value>Relation modality</value>
        [DataMember(Name="taskWorkDocumentOperationRealtionMode", EmitDefaultValue=false)]
        public TaskWorkDocumentOperationRealtionModeEnum? TaskWorkDocumentOperationRealtionMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkDocumentOperationDTO" /> class.
        /// </summary>
        /// <param name="Id">Operation Id..</param>
        /// <param name="TaskWorkId">TaskWork Id..</param>
        /// <param name="ProcessId">Process Id..</param>
        /// <param name="AllowNewDocument">Archiviation enabled..</param>
        /// <param name="AllowDocumentSelection">Selection enabled..</param>
        /// <param name="IsRequired">Required..</param>
        /// <param name="TaskWorkDocumentOperationType">Document type..</param>
        /// <param name="EditBuffer">Edit buffer copy..</param>
        /// <param name="DocumentTypeType1">DocumentType Type one..</param>
        /// <param name="DocumentTypeType2">DocumentType Type two..</param>
        /// <param name="DocumentTypeType3">DocumentType Type three..</param>
        /// <param name="ModuleId">Model Id..</param>
        /// <param name="ToAssociates">Associates enabled..</param>
        /// <param name="Description">Operation description..</param>
        /// <param name="MaskId">Mask Id..</param>
        /// <param name="ToSend">Send enabled..</param>
        /// <param name="FromFileSystem">FileSystem selection..</param>
        /// <param name="FromScanner">Scanner selection..</param>
        /// <param name="IsExecuted">Operation Executed..</param>
        /// <param name="RelatedBinder">Related binder id.</param>
        /// <param name="TaskWorkDocumentOperationRealtionMode">Relation modality.</param>
        public TaskWorkDocumentOperationDTO(string Id = null, int? TaskWorkId = null, int? ProcessId = null, bool? AllowNewDocument = null, bool? AllowDocumentSelection = null, bool? IsRequired = null, TaskWorkDocumentOperationTypeEnum? TaskWorkDocumentOperationType = null, bool? EditBuffer = null, int? DocumentTypeType1 = null, int? DocumentTypeType2 = null, int? DocumentTypeType3 = null, int? ModuleId = null, bool? ToAssociates = null, string Description = null, string MaskId = null, bool? ToSend = null, bool? FromFileSystem = null, bool? FromScanner = null, bool? IsExecuted = null, string RelatedBinder = null, TaskWorkDocumentOperationRealtionModeEnum? TaskWorkDocumentOperationRealtionMode = null)
        {
            this.Id = Id;
            this.TaskWorkId = TaskWorkId;
            this.ProcessId = ProcessId;
            this.AllowNewDocument = AllowNewDocument;
            this.AllowDocumentSelection = AllowDocumentSelection;
            this.IsRequired = IsRequired;
            this.TaskWorkDocumentOperationType = TaskWorkDocumentOperationType;
            this.EditBuffer = EditBuffer;
            this.DocumentTypeType1 = DocumentTypeType1;
            this.DocumentTypeType2 = DocumentTypeType2;
            this.DocumentTypeType3 = DocumentTypeType3;
            this.ModuleId = ModuleId;
            this.ToAssociates = ToAssociates;
            this.Description = Description;
            this.MaskId = MaskId;
            this.ToSend = ToSend;
            this.FromFileSystem = FromFileSystem;
            this.FromScanner = FromScanner;
            this.IsExecuted = IsExecuted;
            this.RelatedBinder = RelatedBinder;
            this.TaskWorkDocumentOperationRealtionMode = TaskWorkDocumentOperationRealtionMode;
        }
        
        /// <summary>
        /// Operation Id.
        /// </summary>
        /// <value>Operation Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// TaskWork Id.
        /// </summary>
        /// <value>TaskWork Id.</value>
        [DataMember(Name="taskWorkId", EmitDefaultValue=false)]
        public int? TaskWorkId { get; set; }
        /// <summary>
        /// Process Id.
        /// </summary>
        /// <value>Process Id.</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }
        /// <summary>
        /// Archiviation enabled.
        /// </summary>
        /// <value>Archiviation enabled.</value>
        [DataMember(Name="allowNewDocument", EmitDefaultValue=false)]
        public bool? AllowNewDocument { get; set; }
        /// <summary>
        /// Selection enabled.
        /// </summary>
        /// <value>Selection enabled.</value>
        [DataMember(Name="allowDocumentSelection", EmitDefaultValue=false)]
        public bool? AllowDocumentSelection { get; set; }
        /// <summary>
        /// Required.
        /// </summary>
        /// <value>Required.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }
        /// <summary>
        /// Edit buffer copy.
        /// </summary>
        /// <value>Edit buffer copy.</value>
        [DataMember(Name="editBuffer", EmitDefaultValue=false)]
        public bool? EditBuffer { get; set; }
        /// <summary>
        /// DocumentType Type one.
        /// </summary>
        /// <value>DocumentType Type one.</value>
        [DataMember(Name="documentTypeType1", EmitDefaultValue=false)]
        public int? DocumentTypeType1 { get; set; }
        /// <summary>
        /// DocumentType Type two.
        /// </summary>
        /// <value>DocumentType Type two.</value>
        [DataMember(Name="documentTypeType2", EmitDefaultValue=false)]
        public int? DocumentTypeType2 { get; set; }
        /// <summary>
        /// DocumentType Type three.
        /// </summary>
        /// <value>DocumentType Type three.</value>
        [DataMember(Name="documentTypeType3", EmitDefaultValue=false)]
        public int? DocumentTypeType3 { get; set; }
        /// <summary>
        /// Model Id.
        /// </summary>
        /// <value>Model Id.</value>
        [DataMember(Name="moduleId", EmitDefaultValue=false)]
        public int? ModuleId { get; set; }
        /// <summary>
        /// Associates enabled.
        /// </summary>
        /// <value>Associates enabled.</value>
        [DataMember(Name="toAssociates", EmitDefaultValue=false)]
        public bool? ToAssociates { get; set; }
        /// <summary>
        /// Operation description.
        /// </summary>
        /// <value>Operation description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Mask Id.
        /// </summary>
        /// <value>Mask Id.</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }
        /// <summary>
        /// Send enabled.
        /// </summary>
        /// <value>Send enabled.</value>
        [DataMember(Name="toSend", EmitDefaultValue=false)]
        public bool? ToSend { get; set; }
        /// <summary>
        /// FileSystem selection.
        /// </summary>
        /// <value>FileSystem selection.</value>
        [DataMember(Name="fromFileSystem", EmitDefaultValue=false)]
        public bool? FromFileSystem { get; set; }
        /// <summary>
        /// Scanner selection.
        /// </summary>
        /// <value>Scanner selection.</value>
        [DataMember(Name="fromScanner", EmitDefaultValue=false)]
        public bool? FromScanner { get; set; }
        /// <summary>
        /// Operation Executed.
        /// </summary>
        /// <value>Operation Executed.</value>
        [DataMember(Name="isExecuted", EmitDefaultValue=false)]
        public bool? IsExecuted { get; set; }
        /// <summary>
        /// Related binder id
        /// </summary>
        /// <value>Related binder id</value>
        [DataMember(Name="relatedBinder", EmitDefaultValue=false)]
        public string RelatedBinder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkDocumentOperationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskWorkId: ").Append(TaskWorkId).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  AllowNewDocument: ").Append(AllowNewDocument).Append("\n");
            sb.Append("  AllowDocumentSelection: ").Append(AllowDocumentSelection).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  TaskWorkDocumentOperationType: ").Append(TaskWorkDocumentOperationType).Append("\n");
            sb.Append("  EditBuffer: ").Append(EditBuffer).Append("\n");
            sb.Append("  DocumentTypeType1: ").Append(DocumentTypeType1).Append("\n");
            sb.Append("  DocumentTypeType2: ").Append(DocumentTypeType2).Append("\n");
            sb.Append("  DocumentTypeType3: ").Append(DocumentTypeType3).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ToAssociates: ").Append(ToAssociates).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  ToSend: ").Append(ToSend).Append("\n");
            sb.Append("  FromFileSystem: ").Append(FromFileSystem).Append("\n");
            sb.Append("  FromScanner: ").Append(FromScanner).Append("\n");
            sb.Append("  IsExecuted: ").Append(IsExecuted).Append("\n");
            sb.Append("  RelatedBinder: ").Append(RelatedBinder).Append("\n");
            sb.Append("  TaskWorkDocumentOperationRealtionMode: ").Append(TaskWorkDocumentOperationRealtionMode).Append("\n");
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
            return this.Equals(obj as TaskWorkDocumentOperationDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkDocumentOperationDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskWorkDocumentOperationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkDocumentOperationDTO other)
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
                    this.TaskWorkId == other.TaskWorkId ||
                    this.TaskWorkId != null &&
                    this.TaskWorkId.Equals(other.TaskWorkId)
                ) && 
                (
                    this.ProcessId == other.ProcessId ||
                    this.ProcessId != null &&
                    this.ProcessId.Equals(other.ProcessId)
                ) && 
                (
                    this.AllowNewDocument == other.AllowNewDocument ||
                    this.AllowNewDocument != null &&
                    this.AllowNewDocument.Equals(other.AllowNewDocument)
                ) && 
                (
                    this.AllowDocumentSelection == other.AllowDocumentSelection ||
                    this.AllowDocumentSelection != null &&
                    this.AllowDocumentSelection.Equals(other.AllowDocumentSelection)
                ) && 
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    this.TaskWorkDocumentOperationType == other.TaskWorkDocumentOperationType ||
                    this.TaskWorkDocumentOperationType != null &&
                    this.TaskWorkDocumentOperationType.Equals(other.TaskWorkDocumentOperationType)
                ) && 
                (
                    this.EditBuffer == other.EditBuffer ||
                    this.EditBuffer != null &&
                    this.EditBuffer.Equals(other.EditBuffer)
                ) && 
                (
                    this.DocumentTypeType1 == other.DocumentTypeType1 ||
                    this.DocumentTypeType1 != null &&
                    this.DocumentTypeType1.Equals(other.DocumentTypeType1)
                ) && 
                (
                    this.DocumentTypeType2 == other.DocumentTypeType2 ||
                    this.DocumentTypeType2 != null &&
                    this.DocumentTypeType2.Equals(other.DocumentTypeType2)
                ) && 
                (
                    this.DocumentTypeType3 == other.DocumentTypeType3 ||
                    this.DocumentTypeType3 != null &&
                    this.DocumentTypeType3.Equals(other.DocumentTypeType3)
                ) && 
                (
                    this.ModuleId == other.ModuleId ||
                    this.ModuleId != null &&
                    this.ModuleId.Equals(other.ModuleId)
                ) && 
                (
                    this.ToAssociates == other.ToAssociates ||
                    this.ToAssociates != null &&
                    this.ToAssociates.Equals(other.ToAssociates)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MaskId == other.MaskId ||
                    this.MaskId != null &&
                    this.MaskId.Equals(other.MaskId)
                ) && 
                (
                    this.ToSend == other.ToSend ||
                    this.ToSend != null &&
                    this.ToSend.Equals(other.ToSend)
                ) && 
                (
                    this.FromFileSystem == other.FromFileSystem ||
                    this.FromFileSystem != null &&
                    this.FromFileSystem.Equals(other.FromFileSystem)
                ) && 
                (
                    this.FromScanner == other.FromScanner ||
                    this.FromScanner != null &&
                    this.FromScanner.Equals(other.FromScanner)
                ) && 
                (
                    this.IsExecuted == other.IsExecuted ||
                    this.IsExecuted != null &&
                    this.IsExecuted.Equals(other.IsExecuted)
                ) && 
                (
                    this.RelatedBinder == other.RelatedBinder ||
                    this.RelatedBinder != null &&
                    this.RelatedBinder.Equals(other.RelatedBinder)
                ) && 
                (
                    this.TaskWorkDocumentOperationRealtionMode == other.TaskWorkDocumentOperationRealtionMode ||
                    this.TaskWorkDocumentOperationRealtionMode != null &&
                    this.TaskWorkDocumentOperationRealtionMode.Equals(other.TaskWorkDocumentOperationRealtionMode)
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
                if (this.TaskWorkId != null)
                    hash = hash * 59 + this.TaskWorkId.GetHashCode();
                if (this.ProcessId != null)
                    hash = hash * 59 + this.ProcessId.GetHashCode();
                if (this.AllowNewDocument != null)
                    hash = hash * 59 + this.AllowNewDocument.GetHashCode();
                if (this.AllowDocumentSelection != null)
                    hash = hash * 59 + this.AllowDocumentSelection.GetHashCode();
                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();
                if (this.TaskWorkDocumentOperationType != null)
                    hash = hash * 59 + this.TaskWorkDocumentOperationType.GetHashCode();
                if (this.EditBuffer != null)
                    hash = hash * 59 + this.EditBuffer.GetHashCode();
                if (this.DocumentTypeType1 != null)
                    hash = hash * 59 + this.DocumentTypeType1.GetHashCode();
                if (this.DocumentTypeType2 != null)
                    hash = hash * 59 + this.DocumentTypeType2.GetHashCode();
                if (this.DocumentTypeType3 != null)
                    hash = hash * 59 + this.DocumentTypeType3.GetHashCode();
                if (this.ModuleId != null)
                    hash = hash * 59 + this.ModuleId.GetHashCode();
                if (this.ToAssociates != null)
                    hash = hash * 59 + this.ToAssociates.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MaskId != null)
                    hash = hash * 59 + this.MaskId.GetHashCode();
                if (this.ToSend != null)
                    hash = hash * 59 + this.ToSend.GetHashCode();
                if (this.FromFileSystem != null)
                    hash = hash * 59 + this.FromFileSystem.GetHashCode();
                if (this.FromScanner != null)
                    hash = hash * 59 + this.FromScanner.GetHashCode();
                if (this.IsExecuted != null)
                    hash = hash * 59 + this.IsExecuted.GetHashCode();
                if (this.RelatedBinder != null)
                    hash = hash * 59 + this.RelatedBinder.GetHashCode();
                if (this.TaskWorkDocumentOperationRealtionMode != null)
                    hash = hash * 59 + this.TaskWorkDocumentOperationRealtionMode.GetHashCode();
                return hash;
            }
        }
    }

}
