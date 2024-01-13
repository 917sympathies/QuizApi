using Quiz.Domain.Common;
using Quiz.Domain.ValueObjects;

namespace Quiz.Domain.Errors
{
    public static class UsernameErrors
    {
        public static Error NullOrEmpty 
            => SharedErrors.NullOrEmpty(nameof(Username));

        public static Error InvalidLength
            => SharedErrors.InvalidLength(nameof(Username), Username.MinLength, Username.MaxLength);
    }
}
