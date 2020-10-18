/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.3.6
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// BankAccount
    /// </summary>
    [DataContract]
    public partial class BankAccount :  IEquatable<BankAccount>, IValidatableObject
    {
        /// <summary>
        /// Calculation type for the transaction can be &#39;Fixed Amount&#39; or &#39;Balance&#39;
        /// </summary>
        /// <value>Calculation type for the transaction can be &#39;Fixed Amount&#39; or &#39;Balance&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalculationTypeEnum
        {
            /// <summary>
            /// Enum FixedAmount for value: FixedAmount
            /// </summary>
            [EnumMember(Value = "FixedAmount")]
            FixedAmount = 1,

            /// <summary>
            /// Enum Balance for value: Balance
            /// </summary>
            [EnumMember(Value = "Balance")]
            Balance = 2

        }

        /// <summary>
        /// Calculation type for the transaction can be &#39;Fixed Amount&#39; or &#39;Balance&#39;
        /// </summary>
        /// <value>Calculation type for the transaction can be &#39;Fixed Amount&#39; or &#39;Balance&#39;</value>
        [DataMember(Name="calculationType", EmitDefaultValue=false)]
        public CalculationTypeEnum CalculationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BankAccount() 
        { 
        }
        
        /// <summary>
        /// Bank account name (max length &#x3D; 32)
        /// </summary>
        /// <value>Bank account name (max length &#x3D; 32)</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Bank account number (digits only; max length &#x3D; 8)
        /// </summary>
        /// <value>Bank account number (digits only; max length &#x3D; 8)</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank account sort code (6 digits)
        /// </summary>
        /// <value>Bank account sort code (6 digits)</value>
        [DataMember(Name="sortCode", EmitDefaultValue=false)]
        public string SortCode { get; set; }

        /// <summary>
        /// Particulars that appear on the statement.
        /// </summary>
        /// <value>Particulars that appear on the statement.</value>
        [DataMember(Name="particulars", EmitDefaultValue=false)]
        public string Particulars { get; set; }

        /// <summary>
        /// Code of a transaction that appear on the statement.
        /// </summary>
        /// <value>Code of a transaction that appear on the statement.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Dollar amount of a transaction.
        /// </summary>
        /// <value>Dollar amount of a transaction.</value>
        [DataMember(Name="dollarAmount", EmitDefaultValue=false)]
        public decimal? DollarAmount { get; set; }

        /// <summary>
        /// Statement Text/reference for a transaction that appear on the statement.
        /// </summary>
        /// <value>Statement Text/reference for a transaction that appear on the statement.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
            sb.Append("  Particulars: ").Append(Particulars).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DollarAmount: ").Append(DollarAmount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
                ) && 
                (
                    this.Particulars == input.Particulars ||
                    (this.Particulars != null &&
                    this.Particulars.Equals(input.Particulars))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DollarAmount == input.DollarAmount ||
                    this.DollarAmount.Equals(input.DollarAmount)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.SortCode != null)
                    hashCode = hashCode * 59 + this.SortCode.GetHashCode();
                if (this.Particulars != null)
                    hashCode = hashCode * 59 + this.Particulars.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.DollarAmount.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
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
