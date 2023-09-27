namespace powerPlantCodingChallenge.Exceptions
{
    public class ValidationException : Exception
    {
        public int StatusCode { get; }

        public ValidationException(string message) : base(message)
        {
            StatusCode = StatusCodes.Status400BadRequest;

        }
    }
}

