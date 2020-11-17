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
    /// OperationConfigurationExecuteSqlQueryRm
    /// </summary>
    [DataContract]
        public partial class OperationConfigurationExecuteSqlQueryRm : OperationsConfigurationRm,  IEquatable<OperationConfigurationExecuteSqlQueryRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationConfigurationExecuteSqlQueryRm" /> class.
        /// </summary>
        /// <param name="sqlInfo">sqlInfo (required).</param>
        public OperationConfigurationExecuteSqlQueryRm(SqlQueryConfigurationInfoRm sqlInfo = default(SqlQueryConfigurationInfoRm), int? operationType = default(int?), OperationRetryConfigurationRm retryConfiguration = default(OperationRetryConfigurationRm), EventInfoRm onErrorEventConfiguration = default(EventInfoRm), EventInfoRm onFailedEventConfiguration = default(EventInfoRm), bool? invalidateOtherOperations = default(bool?), string userDescription = default(string)) : base(operationType, retryConfiguration, onErrorEventConfiguration, onFailedEventConfiguration, invalidateOtherOperations, userDescription)
        {
            // to ensure "sqlInfo" is required (not null)
            if (sqlInfo == null)
            {
                throw new InvalidDataException("sqlInfo is a required property for OperationConfigurationExecuteSqlQueryRm and cannot be null");
            }
            else
            {
                this.SqlInfo = sqlInfo;
            }
        }
        
        /// <summary>
        /// Gets or Sets SqlInfo
        /// </summary>
        [DataMember(Name="sqlInfo", EmitDefaultValue=false)]
        public SqlQueryConfigurationInfoRm SqlInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationConfigurationExecuteSqlQueryRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SqlInfo: ").Append(SqlInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as OperationConfigurationExecuteSqlQueryRm);
        }

        /// <summary>
        /// Returns true if OperationConfigurationExecuteSqlQueryRm instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationConfigurationExecuteSqlQueryRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationConfigurationExecuteSqlQueryRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.SqlInfo == input.SqlInfo ||
                    (this.SqlInfo != null &&
                    this.SqlInfo.Equals(input.SqlInfo))
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
                int hashCode = base.GetHashCode();
                if (this.SqlInfo != null)
                    hashCode = hashCode * 59 + this.SqlInfo.GetHashCode();
                return hashCode;
            }
        }

    }
}
