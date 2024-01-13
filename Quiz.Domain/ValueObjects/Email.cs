using Quiz.Domain.Common;
using Quiz.Domain.Primitives;
using Quiz.Domain.Errors;

namespace Quiz.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Result<Email> Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return EmailErrors.NullOrEmpty;

            if (!email.Contains('@') || !email.Contains('.'))
                return EmailErrors.Invalid;

            return new Email(email);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
