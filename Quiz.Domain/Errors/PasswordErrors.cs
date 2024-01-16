using Quiz.Domain.Common;
using Quiz.Domain.ValueObjects;

namespace Quiz.Domain.Errors
{
    public static class PasswordErrors
    {
        public static Error NullOrEmpty
           => SharedErrors.NullOrEmpty(nameof(Password));

        public static Error InvalidLength
           => SharedErrors.InvalidLength(nameof(Password), Password.MinLength, Password.MaxLength);
    }
}

