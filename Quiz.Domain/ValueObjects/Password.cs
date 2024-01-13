using Quiz.Domain.Common;
using Quiz.Domain.Errors;
using Quiz.Domain.Primitives;

namespace Quiz.Domain.ValueObjects
{
    public class Password : ValueObject
    {
        public const int MaxLength = 100;
        public const int MinLength = 8;
        public string Value { get; }

        private Password(string value)
        {
            Value = value;
        }

        public static Result<Password> From(string password)
        {
            if (string.IsNullOrEmpty(password))
                return PasswordErrors.NullOrEmpty;
            if (password.Length is < MinLength or > MaxLength)
                return PasswordErrors.InvalidLength;
            return new Password(password);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
