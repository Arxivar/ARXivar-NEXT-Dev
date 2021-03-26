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
    /// Class for mail settings
    /// </summary>
    [DataContract]
    public partial class MailServerSettingsDTO :  IEquatable<MailServerSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailServerSettingsDTO" /> class.
        /// </summary>
        /// <param name="server">Server address.</param>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <param name="port">Port.</param>
        /// <param name="securityProtocol">Possible values:  0: None  1: TLS  2: SSL .</param>
        /// <param name="type">Possible values:  0: Imap  1: Smtp  2: Pop3 .</param>
        /// <param name="timeoutConnect">Connection timeout.</param>
        public MailServerSettingsDTO(string server = default(string), string username = default(string), string password = default(string), int? port = default(int?), int? securityProtocol = default(int?), int? type = default(int?), int? timeoutConnect = default(int?))
        {
            this.Server = server;
            this.Username = username;
            this.Password = password;
            this.Port = port;
            this.SecurityProtocol = securityProtocol;
            this.Type = type;
            this.TimeoutConnect = timeoutConnect;
        }
        
        /// <summary>
        /// Server address
        /// </summary>
        /// <value>Server address</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        /// <value>Username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        /// <value>Port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: TLS  2: SSL 
        /// </summary>
        /// <value>Possible values:  0: None  1: TLS  2: SSL </value>
        [DataMember(Name="securityProtocol", EmitDefaultValue=false)]
        public int? SecurityProtocol { get; set; }

        /// <summary>
        /// Possible values:  0: Imap  1: Smtp  2: Pop3 
        /// </summary>
        /// <value>Possible values:  0: Imap  1: Smtp  2: Pop3 </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Connection timeout
        /// </summary>
        /// <value>Connection timeout</value>
        [DataMember(Name="timeoutConnect", EmitDefaultValue=false)]
        public int? TimeoutConnect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailServerSettingsDTO {\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SecurityProtocol: ").Append(SecurityProtocol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeoutConnect: ").Append(TimeoutConnect).Append("\n");
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
            return this.Equals(input as MailServerSettingsDTO);
        }

        /// <summary>
        /// Returns true if MailServerSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailServerSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailServerSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.SecurityProtocol == input.SecurityProtocol ||
                    (this.SecurityProtocol != null &&
                    this.SecurityProtocol.Equals(input.SecurityProtocol))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TimeoutConnect == input.TimeoutConnect ||
                    (this.TimeoutConnect != null &&
                    this.TimeoutConnect.Equals(input.TimeoutConnect))
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
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.SecurityProtocol != null)
                    hashCode = hashCode * 59 + this.SecurityProtocol.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TimeoutConnect != null)
                    hashCode = hashCode * 59 + this.TimeoutConnect.GetHashCode();
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
