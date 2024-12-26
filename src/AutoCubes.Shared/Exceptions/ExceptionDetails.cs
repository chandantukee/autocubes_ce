namespace AutoCubes.Shared.Exceptions
{
    public class ExceptionDetails
    {
        public ExceptionDetails(string message, string code, string type)
        {
            Message = message;
            Code = code;
            Type = type;
        }

        public string Message { get; }
        public string Code { get; }
        public string Type { get; }
    }
}
