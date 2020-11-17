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
    /// Mapping from a variable and a module field
    /// </summary>
    [DataContract]
        public partial class MappingVariableModuleFieldRm :  IEquatable<MappingVariableModuleFieldRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingVariableModuleFieldRm" /> class.
        /// </summary>
        /// <param name="variable">variable (required).</param>
        /// <param name="fieldName">Module field name (required).</param>
        public MappingVariableModuleFieldRm(VariableInfoRm variable = default(VariableInfoRm), string fieldName = default(string))
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for MappingVariableModuleFieldRm and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new InvalidDataException("fieldName is a required property for MappingVariableModuleFieldRm and cannot be null");
            }
            else
            {
                this.FieldName = fieldName;
            }
        }
        
        /// <summary>
        /// Gets or Sets Variable
        /// </summary>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public VariableInfoRm Variable { get; set; }

        /// <summary>
        /// Module field name
        /// </summary>
        /// <value>Module field name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MappingVariableModuleFieldRm {\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
            return this.Equals(input as MappingVariableModuleFieldRm);
        }

        /// <summary>
        /// Returns true if MappingVariableModuleFieldRm instances are equal
        /// </summary>
        /// <param name="input">Instance of MappingVariableModuleFieldRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MappingVariableModuleFieldRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
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
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                return hashCode;
            }
        }

    }
}
