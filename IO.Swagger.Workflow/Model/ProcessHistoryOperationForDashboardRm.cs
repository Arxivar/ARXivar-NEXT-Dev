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
    /// ProcessHistoryOperationForDashboardRm
    /// </summary>
    [DataContract]
        public partial class ProcessHistoryOperationForDashboardRm :  IEquatable<ProcessHistoryOperationForDashboardRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessHistoryOperationForDashboardRm" /> class.
        /// </summary>
        /// <param name="id">Process history operations identifier.</param>
        /// <param name="diagramId">Diagram identifier.</param>
        /// <param name="processId">Process identifier.</param>
        /// <param name="operationDefinition">operationDefinition.</param>
        /// <param name="execOrder">Execution order.</param>
        /// <param name="status">Object status [0&#x3D;Pending, 1&#x3D;Started, 2&#x3D;Finish, 3&#x3D;Suspended, 4&#x3D;Terminated, 5&#x3D;Error, 6&#x3D;TerminatedError, 7&#x3D;NotProcessed, 8&#x3D;Stopped, 9&#x3D;ScheduledStart, 10&#x3D;Incompleted].</param>
        /// <param name="creationDateUtc">Creation date.</param>
        /// <param name="lastUpdateUtc">Last update date.</param>
        /// <param name="activationDateUtc">Activation date.</param>
        /// <param name="endDateUtc">End date.</param>
        /// <param name="messageLevel">Message level [0&#x3D;Info, 1&#x3D;Warning, 2&#x3D;Error].</param>
        /// <param name="messages">Message list.</param>
        /// <param name="retryCount">Number of attempts.</param>
        public ProcessHistoryOperationForDashboardRm(Guid? id = default(Guid?), Guid? diagramId = default(Guid?), Guid? processId = default(Guid?), DiagramOperationSummaryRm operationDefinition = default(DiagramOperationSummaryRm), int? execOrder = default(int?), int? status = default(int?), DateTime? creationDateUtc = default(DateTime?), DateTime? lastUpdateUtc = default(DateTime?), DateTime? activationDateUtc = default(DateTime?), DateTime? endDateUtc = default(DateTime?), int? messageLevel = default(int?), List<ProcessMessageRm> messages = default(List<ProcessMessageRm>), int? retryCount = default(int?))
        {
            this.Id = id;
            this.DiagramId = diagramId;
            this.ProcessId = processId;
            this.OperationDefinition = operationDefinition;
            this.ExecOrder = execOrder;
            this.Status = status;
            this.CreationDateUtc = creationDateUtc;
            this.LastUpdateUtc = lastUpdateUtc;
            this.ActivationDateUtc = activationDateUtc;
            this.EndDateUtc = endDateUtc;
            this.MessageLevel = messageLevel;
            this.Messages = messages;
            this.RetryCount = retryCount;
        }
        
        /// <summary>
        /// Process history operations identifier
        /// </summary>
        /// <value>Process history operations identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Diagram identifier
        /// </summary>
        /// <value>Diagram identifier</value>
        [DataMember(Name="diagramId", EmitDefaultValue=false)]
        public Guid? DiagramId { get; set; }

        /// <summary>
        /// Process identifier
        /// </summary>
        /// <value>Process identifier</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public Guid? ProcessId { get; set; }

        /// <summary>
        /// Gets or Sets OperationDefinition
        /// </summary>
        [DataMember(Name="operationDefinition", EmitDefaultValue=false)]
        public DiagramOperationSummaryRm OperationDefinition { get; set; }

        /// <summary>
        /// Execution order
        /// </summary>
        /// <value>Execution order</value>
        [DataMember(Name="execOrder", EmitDefaultValue=false)]
        public int? ExecOrder { get; set; }

        /// <summary>
        /// Object status [0&#x3D;Pending, 1&#x3D;Started, 2&#x3D;Finish, 3&#x3D;Suspended, 4&#x3D;Terminated, 5&#x3D;Error, 6&#x3D;TerminatedError, 7&#x3D;NotProcessed, 8&#x3D;Stopped, 9&#x3D;ScheduledStart, 10&#x3D;Incompleted]
        /// </summary>
        /// <value>Object status [0&#x3D;Pending, 1&#x3D;Started, 2&#x3D;Finish, 3&#x3D;Suspended, 4&#x3D;Terminated, 5&#x3D;Error, 6&#x3D;TerminatedError, 7&#x3D;NotProcessed, 8&#x3D;Stopped, 9&#x3D;ScheduledStart, 10&#x3D;Incompleted]</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name="creationDateUtc", EmitDefaultValue=false)]
        public DateTime? CreationDateUtc { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        /// <value>Last update date</value>
        [DataMember(Name="lastUpdateUtc", EmitDefaultValue=false)]
        public DateTime? LastUpdateUtc { get; set; }

        /// <summary>
        /// Activation date
        /// </summary>
        /// <value>Activation date</value>
        [DataMember(Name="activationDateUtc", EmitDefaultValue=false)]
        public DateTime? ActivationDateUtc { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        /// <value>End date</value>
        [DataMember(Name="endDateUtc", EmitDefaultValue=false)]
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// Message level [0&#x3D;Info, 1&#x3D;Warning, 2&#x3D;Error]
        /// </summary>
        /// <value>Message level [0&#x3D;Info, 1&#x3D;Warning, 2&#x3D;Error]</value>
        [DataMember(Name="messageLevel", EmitDefaultValue=false)]
        public int? MessageLevel { get; set; }

        /// <summary>
        /// Message list
        /// </summary>
        /// <value>Message list</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ProcessMessageRm> Messages { get; set; }

        /// <summary>
        /// Number of attempts
        /// </summary>
        /// <value>Number of attempts</value>
        [DataMember(Name="retryCount", EmitDefaultValue=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessHistoryOperationForDashboardRm {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DiagramId: ").Append(DiagramId).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  OperationDefinition: ").Append(OperationDefinition).Append("\n");
            sb.Append("  ExecOrder: ").Append(ExecOrder).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationDateUtc: ").Append(CreationDateUtc).Append("\n");
            sb.Append("  LastUpdateUtc: ").Append(LastUpdateUtc).Append("\n");
            sb.Append("  ActivationDateUtc: ").Append(ActivationDateUtc).Append("\n");
            sb.Append("  EndDateUtc: ").Append(EndDateUtc).Append("\n");
            sb.Append("  MessageLevel: ").Append(MessageLevel).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  RetryCount: ").Append(RetryCount).Append("\n");
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
            return this.Equals(input as ProcessHistoryOperationForDashboardRm);
        }

        /// <summary>
        /// Returns true if ProcessHistoryOperationForDashboardRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessHistoryOperationForDashboardRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessHistoryOperationForDashboardRm input)
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
                    this.DiagramId == input.DiagramId ||
                    (this.DiagramId != null &&
                    this.DiagramId.Equals(input.DiagramId))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.OperationDefinition == input.OperationDefinition ||
                    (this.OperationDefinition != null &&
                    this.OperationDefinition.Equals(input.OperationDefinition))
                ) && 
                (
                    this.ExecOrder == input.ExecOrder ||
                    (this.ExecOrder != null &&
                    this.ExecOrder.Equals(input.ExecOrder))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreationDateUtc == input.CreationDateUtc ||
                    (this.CreationDateUtc != null &&
                    this.CreationDateUtc.Equals(input.CreationDateUtc))
                ) && 
                (
                    this.LastUpdateUtc == input.LastUpdateUtc ||
                    (this.LastUpdateUtc != null &&
                    this.LastUpdateUtc.Equals(input.LastUpdateUtc))
                ) && 
                (
                    this.ActivationDateUtc == input.ActivationDateUtc ||
                    (this.ActivationDateUtc != null &&
                    this.ActivationDateUtc.Equals(input.ActivationDateUtc))
                ) && 
                (
                    this.EndDateUtc == input.EndDateUtc ||
                    (this.EndDateUtc != null &&
                    this.EndDateUtc.Equals(input.EndDateUtc))
                ) && 
                (
                    this.MessageLevel == input.MessageLevel ||
                    (this.MessageLevel != null &&
                    this.MessageLevel.Equals(input.MessageLevel))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
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
                if (this.DiagramId != null)
                    hashCode = hashCode * 59 + this.DiagramId.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.OperationDefinition != null)
                    hashCode = hashCode * 59 + this.OperationDefinition.GetHashCode();
                if (this.ExecOrder != null)
                    hashCode = hashCode * 59 + this.ExecOrder.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreationDateUtc != null)
                    hashCode = hashCode * 59 + this.CreationDateUtc.GetHashCode();
                if (this.LastUpdateUtc != null)
                    hashCode = hashCode * 59 + this.LastUpdateUtc.GetHashCode();
                if (this.ActivationDateUtc != null)
                    hashCode = hashCode * 59 + this.ActivationDateUtc.GetHashCode();
                if (this.EndDateUtc != null)
                    hashCode = hashCode * 59 + this.EndDateUtc.GetHashCode();
                if (this.MessageLevel != null)
                    hashCode = hashCode * 59 + this.MessageLevel.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                return hashCode;
            }
        }

    }
}
