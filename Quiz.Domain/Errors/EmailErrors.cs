using Quiz.Domain.Common;
using Quiz.Domain.ValueObjects;

namespace Quiz.Domain.Errors
{
    public static class EmailErrors
    {
        public static Error NullOrEmpty
            => SharedErrors.NullOrEmpty(nameof(Email));

        public static Error Invalid
            => Error.Validation($"Email.{nameof(Invalid)}", "The provided email is not valid");
    }

}
