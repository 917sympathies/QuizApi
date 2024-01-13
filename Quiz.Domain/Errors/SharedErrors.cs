using Quiz.Domain.Common;
using Quiz.Domain.ValueObjects;

namespace Quiz.Domain.Errors
{
    internal class SharedErrors
    {
        internal static Error NullOrEmpty(string parameter)
            => Error.Validation(
                parameter + '.' + nameof(NullOrEmpty),
                $"'{parameter}' can't represent null or empty value");

        internal static Error InvalidLength(string parameter, int min, int max)
            => Error.Validation(
                parameter + '.' + nameof(InvalidLength), 
                $"Password length must be {min} to {max} characters long");
    }
