using Quiz.Domain.Common;
using Quiz.Domain.Errors;
using Quiz.Domain.Primitives;

namespace Quiz.Domain.ValueObjects
{
    public class Username : ValueObject
    {
        public const int MaxLength = 20;
        public const int MinLength = 3;
        public string Value { get; }
        private Username(string value)
        {
            Value = value;
        }

        public static Result<Username> Create(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) 
                return UsernameErrors.NullOrEmpty;
            if (username.Length is > MaxLength or < MinLength)
                return UsernameErrors.InvalidLength;
            return new Username(username);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
