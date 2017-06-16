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
    /// DesktopDTO
    /// </summary>
    [DataContract]
    public partial class DesktopDTO :  IEquatable<DesktopDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopDTO" /> class.
        /// </summary>
        /// <param name="Masks">List of Masks in desktop.</param>
        /// <param name="QuickSearches">List of quickSearch in desktop.</param>
        /// <param name="Profiles">List of profile in desktop.</param>
        /// <param name="Views">List of view in desktop.</param>
        /// <param name="Models">List of models in desktop.</param>
        /// <param name="Folders">List of folders in desktop.</param>
        public DesktopDTO(List<MaskDTO> Masks = null, List<FindDTO> QuickSearches = null, List<ProfileForDesktopDTO> Profiles = null, List<ViewDTO> Views = null, List<ModelDTO> Models = null, List<FolderDTO> Folders = null)
        {
            this.Masks = Masks;
            this.QuickSearches = QuickSearches;
            this.Profiles = Profiles;
            this.Views = Views;
            this.Models = Models;
            this.Folders = Folders;
        }
        
        /// <summary>
        /// List of Masks in desktop
        /// </summary>
        /// <value>List of Masks in desktop</value>
        [DataMember(Name="masks", EmitDefaultValue=false)]
        public List<MaskDTO> Masks { get; set; }
        /// <summary>
        /// List of quickSearch in desktop
        /// </summary>
        /// <value>List of quickSearch in desktop</value>
        [DataMember(Name="quickSearches", EmitDefaultValue=false)]
        public List<FindDTO> QuickSearches { get; set; }
        /// <summary>
        /// List of profile in desktop
        /// </summary>
        /// <value>List of profile in desktop</value>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<ProfileForDesktopDTO> Profiles { get; set; }
        /// <summary>
        /// List of view in desktop
        /// </summary>
        /// <value>List of view in desktop</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<ViewDTO> Views { get; set; }
        /// <summary>
        /// List of models in desktop
        /// </summary>
        /// <value>List of models in desktop</value>
        [DataMember(Name="models", EmitDefaultValue=false)]
        public List<ModelDTO> Models { get; set; }
        /// <summary>
        /// List of folders in desktop
        /// </summary>
        /// <value>List of folders in desktop</value>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<FolderDTO> Folders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopDTO {\n");
            sb.Append("  Masks: ").Append(Masks).Append("\n");
            sb.Append("  QuickSearches: ").Append(QuickSearches).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
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
            return this.Equals(obj as DesktopDTO);
        }

        /// <summary>
        /// Returns true if DesktopDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of DesktopDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Masks == other.Masks ||
                    this.Masks != null &&
                    this.Masks.SequenceEqual(other.Masks)
                ) && 
                (
                    this.QuickSearches == other.QuickSearches ||
                    this.QuickSearches != null &&
                    this.QuickSearches.SequenceEqual(other.QuickSearches)
                ) && 
                (
                    this.Profiles == other.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.SequenceEqual(other.Profiles)
                ) && 
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(other.Views)
                ) && 
                (
                    this.Models == other.Models ||
                    this.Models != null &&
                    this.Models.SequenceEqual(other.Models)
                ) && 
                (
                    this.Folders == other.Folders ||
                    this.Folders != null &&
                    this.Folders.SequenceEqual(other.Folders)
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
                if (this.Masks != null)
                    hash = hash * 59 + this.Masks.GetHashCode();
                if (this.QuickSearches != null)
                    hash = hash * 59 + this.QuickSearches.GetHashCode();
                if (this.Profiles != null)
                    hash = hash * 59 + this.Profiles.GetHashCode();
                if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();
                if (this.Models != null)
                    hash = hash * 59 + this.Models.GetHashCode();
                if (this.Folders != null)
                    hash = hash * 59 + this.Folders.GetHashCode();
                return hash;
            }
        }
    }

}
