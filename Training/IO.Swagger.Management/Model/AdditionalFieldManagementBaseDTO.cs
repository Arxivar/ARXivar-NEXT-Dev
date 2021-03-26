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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Base class of additional field for management
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementStringDTO), "AdditionalFieldManagementStringDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementComboDTO), "AdditionalFieldManagementComboDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementMultivalueDTO), "AdditionalFieldManagementMultivalueDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementNumericDTO), "AdditionalFieldManagementNumericDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementDateTimeDTO), "AdditionalFieldManagementDateTimeDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementTableDTO), "AdditionalFieldManagementTableDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementClasseDTO), "AdditionalFieldManagementClasseDTO")]
    [JsonSubtypes.KnownSubType(typeof(AdditionalFieldManagementBooleanDTO), "AdditionalFieldManagementBooleanDTO")]
    public partial class AdditionalFieldManagementBaseDTO :  IEquatable<AdditionalFieldManagementBaseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementBaseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldManagementBaseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementBaseDTO" /> class.
        /// </summary>
        /// <param name="className">Name of class (required).</param>
        /// <param name="key">Field key.</param>
        /// <param name="description">Field description.</param>
        /// <param name="fieldGroup">Field group.</param>
        /// <param name="documentType">Document type.</param>
        /// <param name="referenceId">Reference Identifier.</param>
        /// <param name="order">Order.</param>
        /// <param name="required">Required.</param>
        /// <param name="visible">Visible.</param>
        /// <param name="externalId">External Id.</param>
        /// <param name="formula">Formula.</param>
        /// <param name="translations">Field description and errors translations.</param>
        public AdditionalFieldManagementBaseDTO(string className = default(string), string key = default(string), string description = default(string), FieldGroupSimpleDTO fieldGroup = default(FieldGroupSimpleDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), string referenceId = default(string), int? order = default(int?), bool? required = default(bool?), bool? visible = default(bool?), string externalId = default(string), string formula = default(string), List<AdditionalFieldManagementTranslationDTO> translations = default(List<AdditionalFieldManagementTranslationDTO>))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for AdditionalFieldManagementBaseDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
            this.Key = key;
            this.Description = description;
            this.FieldGroup = fieldGroup;
            this.DocumentType = documentType;
            this.ReferenceId = referenceId;
            this.Order = order;
            this.Required = required;
            this.Visible = visible;
            this.ExternalId = externalId;
            this.Formula = formula;
            this.Translations = translations;
        }
        
        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Field key
        /// </summary>
        /// <value>Field key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Field description
        /// </summary>
        /// <value>Field description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Field group
        /// </summary>
        /// <value>Field group</value>
        [DataMember(Name="fieldGroup", EmitDefaultValue=false)]
        public FieldGroupSimpleDTO FieldGroup { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Reference Identifier
        /// </summary>
        /// <value>Reference Identifier</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        /// <value>Required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Visible
        /// </summary>
        /// <value>Visible</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// External Id
        /// </summary>
        /// <value>External Id</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Formula
        /// </summary>
        /// <value>Formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Field description and errors translations
        /// </summary>
        /// <value>Field description and errors translations</value>
        [DataMember(Name="translations", EmitDefaultValue=false)]
        public List<AdditionalFieldManagementTranslationDTO> Translations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementBaseDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldGroup: ").Append(FieldGroup).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
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
            return this.Equals(input as AdditionalFieldManagementBaseDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementBaseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementBaseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldGroup == input.FieldGroup ||
                    (this.FieldGroup != null &&
                    this.FieldGroup.Equals(input.FieldGroup))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FieldGroup != null)
                    hashCode = hashCode * 59 + this.FieldGroup.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.Translations != null)
                    hashCode = hashCode * 59 + this.Translations.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
