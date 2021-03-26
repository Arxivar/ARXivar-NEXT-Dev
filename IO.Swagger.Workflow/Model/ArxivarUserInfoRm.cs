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
    /// ARXivar user information
    /// </summary>
    [DataContract]
        public partial class ArxivarUserInfoRm :  IEquatable<ArxivarUserInfoRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxivarUserInfoRm" /> class.
        /// </summary>
        /// <param name="dmUtentiId">ARXivar user identifier.</param>
        /// <param name="bu">Business unit.</param>
        /// <param name="description">ARXivar user description.</param>
        /// <param name="lang">User default language.</param>
        /// <param name="isGroup">Indicates if is a group.</param>
        public ArxivarUserInfoRm(int? dmUtentiId = default(int?), string bu = default(string), string description = default(string), string lang = default(string), bool? isGroup = default(bool?))
        {
            this.DmUtentiId = dmUtentiId;
            this.Bu = bu;
            this.Description = description;
            this.Lang = lang;
            this.IsGroup = isGroup;
        }
        
        /// <summary>
        /// ARXivar user identifier
        /// </summary>
        /// <value>ARXivar user identifier</value>
        [DataMember(Name="dmUtentiId", EmitDefaultValue=false)]
        public int? DmUtentiId { get; set; }

        /// <summary>
        /// Business unit
        /// </summary>
        /// <value>Business unit</value>
        [DataMember(Name="bu", EmitDefaultValue=false)]
        public string Bu { get; set; }

        /// <summary>
        /// ARXivar user description
        /// </summary>
        /// <value>ARXivar user description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// User default language
        /// </summary>
        /// <value>User default language</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Indicates if is a group
        /// </summary>
        /// <value>Indicates if is a group</value>
        [DataMember(Name="isGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxivarUserInfoRm {\n");
            sb.Append("  DmUtentiId: ").Append(DmUtentiId).Append("\n");
            sb.Append("  Bu: ").Append(Bu).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
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
            return this.Equals(input as ArxivarUserInfoRm);
        }

        /// <summary>
        /// Returns true if ArxivarUserInfoRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxivarUserInfoRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxivarUserInfoRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DmUtentiId == input.DmUtentiId ||
                    (this.DmUtentiId != null &&
                    this.DmUtentiId.Equals(input.DmUtentiId))
                ) && 
                (
                    this.Bu == input.Bu ||
                    (this.Bu != null &&
                    this.Bu.Equals(input.Bu))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    (this.IsGroup != null &&
                    this.IsGroup.Equals(input.IsGroup))
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
                if (this.DmUtentiId != null)
                    hashCode = hashCode * 59 + this.DmUtentiId.GetHashCode();
                if (this.Bu != null)
                    hashCode = hashCode * 59 + this.Bu.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.IsGroup != null)
                    hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                return hashCode;
            }
        }

    }
}