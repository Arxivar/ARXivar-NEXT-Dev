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
    /// TaskLayoutAssociationDTO
    /// </summary>
    [DataContract]
    public partial class TaskLayoutAssociationDTO :  IEquatable<TaskLayoutAssociationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLayoutAssociationDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="taskWorkExternalId">taskWorkExternalId.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="associationType">Possible values:  0: WorkflowAssociation  1: TaskWorkAssociation .</param>
        /// <param name="taskLayoutId">taskLayoutId.</param>
        public TaskLayoutAssociationDTO(int? id = default(int?), string taskWorkExternalId = default(string), int? workflowId = default(int?), int? associationType = default(int?), int? taskLayoutId = default(int?))
        {
            this.Id = id;
            this.TaskWorkExternalId = taskWorkExternalId;
            this.WorkflowId = workflowId;
            this.AssociationType = associationType;
            this.TaskLayoutId = taskLayoutId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets TaskWorkExternalId
        /// </summary>
        [DataMember(Name="taskWorkExternalId", EmitDefaultValue=false)]
        public string TaskWorkExternalId { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public int? WorkflowId { get; set; }

        /// <summary>
        /// Possible values:  0: WorkflowAssociation  1: TaskWorkAssociation 
        /// </summary>
        /// <value>Possible values:  0: WorkflowAssociation  1: TaskWorkAssociation </value>
        [DataMember(Name="associationType", EmitDefaultValue=false)]
        public int? AssociationType { get; set; }

        /// <summary>
        /// Gets or Sets TaskLayoutId
        /// </summary>
        [DataMember(Name="taskLayoutId", EmitDefaultValue=false)]
        public int? TaskLayoutId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLayoutAssociationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskWorkExternalId: ").Append(TaskWorkExternalId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  AssociationType: ").Append(AssociationType).Append("\n");
            sb.Append("  TaskLayoutId: ").Append(TaskLayoutId).Append("\n");
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
            return this.Equals(input as TaskLayoutAssociationDTO);
        }

        /// <summary>
        /// Returns true if TaskLayoutAssociationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskLayoutAssociationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLayoutAssociationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TaskWorkExternalId == input.TaskWorkExternalId ||
                    (this.TaskWorkExternalId != null &&
                    this.TaskWorkExternalId.Equals(input.TaskWorkExternalId))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.AssociationType == input.AssociationType ||
                    (this.AssociationType != null &&
                    this.AssociationType.Equals(input.AssociationType))
                ) && 
                (
                    this.TaskLayoutId == input.TaskLayoutId ||
                    (this.TaskLayoutId != null &&
                    this.TaskLayoutId.Equals(input.TaskLayoutId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskWorkExternalId != null)
                    hashCode = hashCode * 59 + this.TaskWorkExternalId.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.AssociationType != null)
                    hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.TaskLayoutId != null)
                    hashCode = hashCode * 59 + this.TaskLayoutId.GetHashCode();
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
