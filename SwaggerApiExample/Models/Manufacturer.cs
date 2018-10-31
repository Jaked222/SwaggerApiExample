﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Manufacturer : IEquatable<Manufacturer>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HomePage
        /// </summary>
        [DataMember(Name = "homePage")]
        public string HomePage { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Manufacturer {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HomePage: ").Append(HomePage).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Manufacturer)obj);
        }

        /// <summary>
        /// Returns true if Manufacturer instances are equal
        /// </summary>
        /// <param name="other">Instance of Manufacturer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Manufacturer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    HomePage == other.HomePage ||
                    HomePage != null &&
                    HomePage.Equals(other.HomePage)
                ) &&
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (HomePage != null)
                    hashCode = hashCode * 59 + HomePage.GetHashCode();
                if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Manufacturer left, Manufacturer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Manufacturer left, Manufacturer right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
