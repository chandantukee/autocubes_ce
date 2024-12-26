using AutoCubes.Shared.Exceptions;

namespace AutoCubes.Shared.Api
{
    public class ApiResponse
    {
        private List<ExceptionDetails> _errors;
        public ApiResponse()
        {
            _errors = new List<ExceptionDetails>();
        }
        public bool IsSuccess { get; set; }
        public List<ExceptionDetails> Errors { get { return _errors; } set { _errors = value; } }
        public ResponseData ResponseData { get; set; }
    }
}
