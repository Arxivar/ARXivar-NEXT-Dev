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
    /// VariableFiltersDTO
    /// </summary>
    [DataContract]
    public partial class VariableFiltersDTO :  IEquatable<VariableFiltersDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableFiltersDTO" /> class.
        /// </summary>
        /// <param name="DateTimeFields">Array of avaible filters for the additional field DateTime.</param>
        /// <param name="StringFields">Array of avaible filters for the additional field string.</param>
        /// <param name="IntFields">Array of avaible filters for the additional field int.</param>
        /// <param name="BoolFields">Array of avaible filters for the additional field bool.</param>
        /// <param name="DoubleFields">Array of avaible filters for the additional field double.</param>
        /// <param name="StringListFields">Array of avaible filters for the additional field stringlist.</param>
        public VariableFiltersDTO(List<FieldBaseForSearchDateTimeDto> DateTimeFields = null, List<FieldBaseForSearchStringDto> StringFields = null, List<FieldBaseForSearchIntDto> IntFields = null, List<FieldBaseForSearchBoolDto> BoolFields = null, List<FieldBaseForSearchDoubleDto> DoubleFields = null, List<FieldBaseForSearchListDto> StringListFields = null)
        {
            this.DateTimeFields = DateTimeFields;
            this.StringFields = StringFields;
            this.IntFields = IntFields;
            this.BoolFields = BoolFields;
            this.DoubleFields = DoubleFields;
            this.StringListFields = StringListFields;
        }
        
        /// <summary>
        /// Array of avaible filters for the additional field DateTime
        /// </summary>
        /// <value>Array of avaible filters for the additional field DateTime</value>
        [DataMember(Name="dateTimeFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDateTimeDto> DateTimeFields { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field string
        /// </summary>
        /// <value>Array of avaible filters for the additional field string</value>
        [DataMember(Name="stringFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchStringDto> StringFields { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field int
        /// </summary>
        /// <value>Array of avaible filters for the additional field int</value>
        [DataMember(Name="intFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchIntDto> IntFields { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field bool
        /// </summary>
        /// <value>Array of avaible filters for the additional field bool</value>
        [DataMember(Name="boolFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchBoolDto> BoolFields { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field double
        /// </summary>
        /// <value>Array of avaible filters for the additional field double</value>
        [DataMember(Name="doubleFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDoubleDto> DoubleFields { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field stringlist
        /// </summary>
        /// <value>Array of avaible filters for the additional field stringlist</value>
        [DataMember(Name="stringListFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchListDto> StringListFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableFiltersDTO {\n");
            sb.Append("  DateTimeFields: ").Append(DateTimeFields).Append("\n");
            sb.Append("  StringFields: ").Append(StringFields).Append("\n");
            sb.Append("  IntFields: ").Append(IntFields).Append("\n");
            sb.Append("  BoolFields: ").Append(BoolFields).Append("\n");
            sb.Append("  DoubleFields: ").Append(DoubleFields).Append("\n");
            sb.Append("  StringListFields: ").Append(StringListFields).Append("\n");
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
            return this.Equals(obj as VariableFiltersDTO);
        }

        /// <summary>
        /// Returns true if VariableFiltersDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of VariableFiltersDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableFiltersDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateTimeFields == other.DateTimeFields ||
                    this.DateTimeFields != null &&
                    this.DateTimeFields.SequenceEqual(other.DateTimeFields)
                ) && 
                (
                    this.StringFields == other.StringFields ||
                    this.StringFields != null &&
                    this.StringFields.SequenceEqual(other.StringFields)
                ) && 
                (
                    this.IntFields == other.IntFields ||
                    this.IntFields != null &&
                    this.IntFields.SequenceEqual(other.IntFields)
                ) && 
                (
                    this.BoolFields == other.BoolFields ||
                    this.BoolFields != null &&
                    this.BoolFields.SequenceEqual(other.BoolFields)
                ) && 
                (
                    this.DoubleFields == other.DoubleFields ||
                    this.DoubleFields != null &&
                    this.DoubleFields.SequenceEqual(other.DoubleFields)
                ) && 
                (
                    this.StringListFields == other.StringListFields ||
                    this.StringListFields != null &&
                    this.StringListFields.SequenceEqual(other.StringListFields)
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
                if (this.DateTimeFields != null)
                    hash = hash * 59 + this.DateTimeFields.GetHashCode();
                if (this.StringFields != null)
                    hash = hash * 59 + this.StringFields.GetHashCode();
                if (this.IntFields != null)
                    hash = hash * 59 + this.IntFields.GetHashCode();
                if (this.BoolFields != null)
                    hash = hash * 59 + this.BoolFields.GetHashCode();
                if (this.DoubleFields != null)
                    hash = hash * 59 + this.DoubleFields.GetHashCode();
                if (this.StringListFields != null)
                    hash = hash * 59 + this.StringListFields.GetHashCode();
                return hash;
            }
        }
    }

}