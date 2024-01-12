using Quiz.Domain.Common;

namespace Quiz.Domain.Errors
{
    public static class EmailErrors
    {
        public static Error NullOrEmptyEmail
            => Error.Validation("Email.NullOrEmptyValue", "Email can't represent null or empty value");

        public static Error InvalidEmail
            => Error.Validation("Email.Invalid", "The provided email is not valid");
    }

}
