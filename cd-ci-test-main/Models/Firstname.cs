namespace ValidateTheNameModelBinding.Models
{
    using System;
    using System.Text.RegularExpressions;

    namespace ValidateTheNameModelBinding.Models
    {
        public class Firstname
        {
            public string Value { get; }

            // ... (konstanter)

            public Firstname(string value)
            {
                // ------------- INVARIANSEN ER NU UDKOMMENTERET -------------
                /*
                if (value == null) throw new ArgumentNullException(nameof(value));

                var trimmed = value.Trim();
                if (trimmed.Length < MinLength || trimmed.Length > MaxLength)
                    throw new ArgumentException($"Firstname must be between {MinLength} and {MaxLength} characters.");

                if (!AllowedPattern.IsMatch(trimmed))
                    throw new ArgumentException("Firstname contains invalid characters.");

                Value = trimmed;
                */
                // ------------- NY LINJE TILFØJET UDEN VALIDERING -------------
                Value = value; // Sætter værdien direkte, selvom den er ugyldig!
            }

            public override string ToString() => Value;
        }
    }
}