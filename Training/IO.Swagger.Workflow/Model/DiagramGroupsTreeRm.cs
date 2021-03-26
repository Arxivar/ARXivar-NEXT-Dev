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
    /// Diagram group tree structur model
    /// </summary>
    [DataContract]
        public partial class DiagramGroupsTreeRm :  IEquatable<DiagramGroupsTreeRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramGroupsTreeRm" /> class.
        /// </summary>
        /// <param name="childs">List of child elements.</param>
        public DiagramGroupsTreeRm(List<GroupTreeItemBaseRm> childs = default(List<GroupTreeItemBaseRm>))
        {
            this.Childs = childs;
        }
        
        /// <summary>
        /// List of child elements
        /// </summary>
        /// <value>List of child elements</value>
        [DataMember(Name="childs", EmitDefaultValue=false)]
        public List<GroupTreeItemBaseRm> Childs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramGroupsTreeRm {\n");
            sb.Append("  Childs: ").Append(Childs).Append("\n");
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
            return this.Equals(input as DiagramGroupsTreeRm);
        }

        /// <summary>
        /// Returns true if DiagramGroupsTreeRm instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramGroupsTreeRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramGroupsTreeRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Childs == input.Childs ||
                    this.Childs != null &&
                    input.Childs != null &&
                    this.Childs.SequenceEqual(input.Childs)
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
                if (this.Childs != null)
                    hashCode = hashCode * 59 + this.Childs.GetHashCode();
                return hashCode;
            }
        }

    }
}
