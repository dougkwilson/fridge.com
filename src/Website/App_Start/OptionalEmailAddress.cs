using System;
using System.ComponentModel.DataAnnotations;

namespace Website
{
    public sealed class OptionalEmailAddressAttribute : DataTypeAttribute
    {
        public OptionalEmailAddressAttribute()
          : base(DataType.EmailAddress) {
        }

        /// <summary>Determines whether the specified value matches the pattern of a valid email address.</summary>
        /// <returns>true if the specified value is valid, null or empty; otherwise, false.</returns>
        /// <param name="value">The value to validate.</param>
        public override Boolean IsValid(Object value) {
            if (value == null)
                return true;

            String email = value as String;
            if (String.IsNullOrWhiteSpace(email))
                return true;

            return email.IsEmail();
        }
    }
}
