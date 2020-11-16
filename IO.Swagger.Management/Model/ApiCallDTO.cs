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
    /// Class of API call
    /// </summary>
    [DataContract]
    public partial class ApiCallDTO :  IEquatable<ApiCallDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCallDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="context">Possible values:  0: Generic  1: Workflow  2: Process .</param>
        /// <param name="type">Possible values:  0: Authentication  1: Generic .</param>
        /// <param name="description">Description.</param>
        /// <param name="endpoint">Call endpoint.</param>
        /// <param name="method">Possible values:  0: GET  1: POST  2: PUT  4: DELETE .</param>
        /// <param name="jsonBody">Request json data.</param>
        /// <param name="authMode">Possible values:  0: None  1: BasicAuthentication  2: Windows  3: Jwt  4: OAuth  5: Custom .</param>
        /// <param name="authenticationCallId">Authetication call identifier.</param>
        /// <param name="enableCache">Cache enabled.</param>
        /// <param name="cacheDuration">Cache duration.</param>
        /// <param name="referenceId">Reference identifier.</param>
        /// <param name="headers">Headers.</param>
        /// <param name="variablesIn">Input Variables.</param>
        /// <param name="variablesOut">Output Variables.</param>
        public ApiCallDTO(int? id = default(int?), int? context = default(int?), int? type = default(int?), string description = default(string), string endpoint = default(string), int? method = default(int?), string jsonBody = default(string), int? authMode = default(int?), int? authenticationCallId = default(int?), bool? enableCache = default(bool?), int? cacheDuration = default(int?), string referenceId = default(string), List<ApiCallHeaderDTO> headers = default(List<ApiCallHeaderDTO>), List<ApiCallVariableInDTO> variablesIn = default(List<ApiCallVariableInDTO>), List<ApiCallVariableOutDTO> variablesOut = default(List<ApiCallVariableOutDTO>))
        {
            this.Id = id;
            this.Context = context;
            this.Type = type;
            this.Description = description;
            this.Endpoint = endpoint;
            this.Method = method;
            this.JsonBody = jsonBody;
            this.AuthMode = authMode;
            this.AuthenticationCallId = authenticationCallId;
            this.EnableCache = enableCache;
            this.CacheDuration = cacheDuration;
            this.ReferenceId = referenceId;
            this.Headers = headers;
            this.VariablesIn = variablesIn;
            this.VariablesOut = variablesOut;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Possible values:  0: Generic  1: Workflow  2: Process 
        /// </summary>
        /// <value>Possible values:  0: Generic  1: Workflow  2: Process </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public int? Context { get; set; }

        /// <summary>
        /// Possible values:  0: Authentication  1: Generic 
        /// </summary>
        /// <value>Possible values:  0: Authentication  1: Generic </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Call endpoint
        /// </summary>
        /// <value>Call endpoint</value>
        [DataMember(Name="endpoint", EmitDefaultValue=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Possible values:  0: GET  1: POST  2: PUT  4: DELETE 
        /// </summary>
        /// <value>Possible values:  0: GET  1: POST  2: PUT  4: DELETE </value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public int? Method { get; set; }

        /// <summary>
        /// Request json data
        /// </summary>
        /// <value>Request json data</value>
        [DataMember(Name="jsonBody", EmitDefaultValue=false)]
        public string JsonBody { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: BasicAuthentication  2: Windows  3: Jwt  4: OAuth  5: Custom 
        /// </summary>
        /// <value>Possible values:  0: None  1: BasicAuthentication  2: Windows  3: Jwt  4: OAuth  5: Custom </value>
        [DataMember(Name="authMode", EmitDefaultValue=false)]
        public int? AuthMode { get; set; }

        /// <summary>
        /// Authetication call identifier
        /// </summary>
        /// <value>Authetication call identifier</value>
        [DataMember(Name="authenticationCallId", EmitDefaultValue=false)]
        public int? AuthenticationCallId { get; set; }

        /// <summary>
        /// Cache enabled
        /// </summary>
        /// <value>Cache enabled</value>
        [DataMember(Name="enableCache", EmitDefaultValue=false)]
        public bool? EnableCache { get; set; }

        /// <summary>
        /// Cache duration
        /// </summary>
        /// <value>Cache duration</value>
        [DataMember(Name="cacheDuration", EmitDefaultValue=false)]
        public int? CacheDuration { get; set; }

        /// <summary>
        /// Reference identifier
        /// </summary>
        /// <value>Reference identifier</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Headers
        /// </summary>
        /// <value>Headers</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<ApiCallHeaderDTO> Headers { get; set; }

        /// <summary>
        /// Input Variables
        /// </summary>
        /// <value>Input Variables</value>
        [DataMember(Name="variablesIn", EmitDefaultValue=false)]
        public List<ApiCallVariableInDTO> VariablesIn { get; set; }

        /// <summary>
        /// Output Variables
        /// </summary>
        /// <value>Output Variables</value>
        [DataMember(Name="variablesOut", EmitDefaultValue=false)]
        public List<ApiCallVariableOutDTO> VariablesOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiCallDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  JsonBody: ").Append(JsonBody).Append("\n");
            sb.Append("  AuthMode: ").Append(AuthMode).Append("\n");
            sb.Append("  AuthenticationCallId: ").Append(AuthenticationCallId).Append("\n");
            sb.Append("  EnableCache: ").Append(EnableCache).Append("\n");
            sb.Append("  CacheDuration: ").Append(CacheDuration).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  VariablesIn: ").Append(VariablesIn).Append("\n");
            sb.Append("  VariablesOut: ").Append(VariablesOut).Append("\n");
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
            return this.Equals(input as ApiCallDTO);
        }

        /// <summary>
        /// Returns true if ApiCallDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiCallDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiCallDTO input)
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
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.JsonBody == input.JsonBody ||
                    (this.JsonBody != null &&
                    this.JsonBody.Equals(input.JsonBody))
                ) && 
                (
                    this.AuthMode == input.AuthMode ||
                    (this.AuthMode != null &&
                    this.AuthMode.Equals(input.AuthMode))
                ) && 
                (
                    this.AuthenticationCallId == input.AuthenticationCallId ||
                    (this.AuthenticationCallId != null &&
                    this.AuthenticationCallId.Equals(input.AuthenticationCallId))
                ) && 
                (
                    this.EnableCache == input.EnableCache ||
                    (this.EnableCache != null &&
                    this.EnableCache.Equals(input.EnableCache))
                ) && 
                (
                    this.CacheDuration == input.CacheDuration ||
                    (this.CacheDuration != null &&
                    this.CacheDuration.Equals(input.CacheDuration))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.VariablesIn == input.VariablesIn ||
                    this.VariablesIn != null &&
                    this.VariablesIn.SequenceEqual(input.VariablesIn)
                ) && 
                (
                    this.VariablesOut == input.VariablesOut ||
                    this.VariablesOut != null &&
                    this.VariablesOut.SequenceEqual(input.VariablesOut)
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.JsonBody != null)
                    hashCode = hashCode * 59 + this.JsonBody.GetHashCode();
                if (this.AuthMode != null)
                    hashCode = hashCode * 59 + this.AuthMode.GetHashCode();
                if (this.AuthenticationCallId != null)
                    hashCode = hashCode * 59 + this.AuthenticationCallId.GetHashCode();
                if (this.EnableCache != null)
                    hashCode = hashCode * 59 + this.EnableCache.GetHashCode();
                if (this.CacheDuration != null)
                    hashCode = hashCode * 59 + this.CacheDuration.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.VariablesIn != null)
                    hashCode = hashCode * 59 + this.VariablesIn.GetHashCode();
                if (this.VariablesOut != null)
                    hashCode = hashCode * 59 + this.VariablesOut.GetHashCode();
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
