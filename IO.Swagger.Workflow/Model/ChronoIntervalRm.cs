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
    /// Chronometer interval
    /// </summary>
    [DataContract]
        public partial class ChronoIntervalRm :  IEquatable<ChronoIntervalRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChronoIntervalRm" /> class.
        /// </summary>
        /// <param name="dateStartUtc">Datetime start.</param>
        /// <param name="dateStopUtc">Datetime stop.</param>
        /// <param name="index">Chronometer index.</param>
        /// <param name="secondsDuration">Seconds duration.</param>
        public ChronoIntervalRm(DateTime? dateStartUtc = default(DateTime?), DateTime? dateStopUtc = default(DateTime?), int? index = default(int?), double? secondsDuration = default(double?))
        {
            this.DateStartUtc = dateStartUtc;
            this.DateStopUtc = dateStopUtc;
            this.Index = index;
            this.SecondsDuration = secondsDuration;
        }
        
        /// <summary>
        /// Datetime start
        /// </summary>
        /// <value>Datetime start</value>
        [DataMember(Name="dateStartUtc", EmitDefaultValue=false)]
        public DateTime? DateStartUtc { get; set; }

        /// <summary>
        /// Datetime stop
        /// </summary>
        /// <value>Datetime stop</value>
        [DataMember(Name="dateStopUtc", EmitDefaultValue=false)]
        public DateTime? DateStopUtc { get; set; }

        /// <summary>
        /// Chronometer index
        /// </summary>
        /// <value>Chronometer index</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Seconds duration
        /// </summary>
        /// <value>Seconds duration</value>
        [DataMember(Name="secondsDuration", EmitDefaultValue=false)]
        public double? SecondsDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChronoIntervalRm {\n");
            sb.Append("  DateStartUtc: ").Append(DateStartUtc).Append("\n");
            sb.Append("  DateStopUtc: ").Append(DateStopUtc).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  SecondsDuration: ").Append(SecondsDuration).Append("\n");
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
            return this.Equals(input as ChronoIntervalRm);
        }

        /// <summary>
        /// Returns true if ChronoIntervalRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ChronoIntervalRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChronoIntervalRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateStartUtc == input.DateStartUtc ||
                    (this.DateStartUtc != null &&
                    this.DateStartUtc.Equals(input.DateStartUtc))
                ) && 
                (
                    this.DateStopUtc == input.DateStopUtc ||
                    (this.DateStopUtc != null &&
                    this.DateStopUtc.Equals(input.DateStopUtc))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.SecondsDuration == input.SecondsDuration ||
                    (this.SecondsDuration != null &&
                    this.SecondsDuration.Equals(input.SecondsDuration))
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
                if (this.DateStartUtc != null)
                    hashCode = hashCode * 59 + this.DateStartUtc.GetHashCode();
                if (this.DateStopUtc != null)
                    hashCode = hashCode * 59 + this.DateStopUtc.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.SecondsDuration != null)
                    hashCode = hashCode * 59 + this.SecondsDuration.GetHashCode();
                return hashCode;
            }
        }

    }
}
