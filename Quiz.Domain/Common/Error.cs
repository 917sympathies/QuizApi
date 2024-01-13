namespace Quiz.Domain.Common
{
    public record Error
    {
        public string Code { get; init; }

        public string Description { get; init; }

        public ErrorType ErrorType { get; init; }

        private Error(string code, string description, ErrorType errorType)
        {
            Code = code;
            Description = description;
            ErrorType = errorType;
        }

        public static Error None => new(string.Empty, string.Empty, ErrorType.Failure);
        public static Error Validation(string code, string description) 
            => new(code, description, ErrorType.Validation);
        public static Error NotFound(string code, string description)
            => new(code, description, ErrorType.NotFound);
        public static Error Conflict(string code, string description)
            => new(code, description, ErrorType.Conflict);
        public static Error Failure(string code, string description)
            => new(code, description, ErrorType.Failure);
    }
}
