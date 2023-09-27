namespace powerPlantCodingChallenge.Exceptions
{
    public class ComputeException : Exception
    {
        public int StatusCode { get; }

        public ComputeException(string message) : base(message)
        {
            StatusCode = StatusCodes.Status422UnprocessableEntity;

        }
    }
}

