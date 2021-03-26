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
    /// FieldBaseForSearchBoolDto
    /// </summary>
    [DataContract]
    public partial class FieldBaseForSearchBoolDto :  IEquatable<FieldBaseForSearchBoolDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchBoolDto" /> class.
        /// </summary>
        /// <param name="_operator">Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso .</param>
        /// <param name="valore1">The value of this field.</param>
        /// <param name="valore2">The second value for this field (used only for some operator).</param>
        public FieldBaseForSearchBoolDto(int? _operator = default(int?), bool? valore1 = default(bool?), bool? valore2 = default(bool?))
        {
            this.Operator = _operator;
            this.Valore1 = valore1;
            this.Valore2 = valore2;
        }
        
        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? Operator { get; set; }

        /// <summary>
        /// The value of this field
        /// </summary>
        /// <value>The value of this field</value>
        [DataMember(Name="valore1", EmitDefaultValue=false)]
        public bool? Valore1 { get; set; }

        /// <summary>
        /// The second value for this field (used only for some operator)
        /// </summary>
        /// <value>The second value for this field (used only for some operator)</value>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public bool? Valore2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchBoolDto {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Valore1: ").Append(Valore1).Append("\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
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
            return this.Equals(input as FieldBaseForSearchBoolDto);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchBoolDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSearchBoolDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchBoolDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Valore1 == input.Valore1 ||
                    (this.Valore1 != null &&
                    this.Valore1.Equals(input.Valore1))
                ) && 
                (
                    this.Valore2 == input.Valore2 ||
                    (this.Valore2 != null &&
                    this.Valore2.Equals(input.Valore2))
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
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Valore1 != null)
                    hashCode = hashCode * 59 + this.Valore1.GetHashCode();
                if (this.Valore2 != null)
                    hashCode = hashCode * 59 + this.Valore2.GetHashCode();
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