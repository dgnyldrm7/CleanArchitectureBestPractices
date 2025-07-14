using CleanArchitecture.Shared.Result;
using System.Net;

namespace CleanArchitecture.Shared.ResultPattern
{
    public class GenericResult<T> where T : class
    {
        private GenericResult() : this(true) {}

        private GenericResult(bool isSuccess)
        {
            IsSuccess = isSuccess;

            if(!isSuccess)
            {
                Data = null;
            }
        }

        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public T? Data { get; set; }
        public ProblemDetails? ProblemDetails { get; private init; } = new();

        public static GenericResult<T> Success(T data)
        {
            return new GenericResult<T>(true)
            { 
                Data = data 
            };
        }

        public static GenericResult<T> Failure(string errorMessage)
        {
            return new GenericResult<T>(false)
            { 

                ProblemDetails = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Title = "Bad Request",
                    Detail = errorMessage
                },

                ErrorMessage = errorMessage 
            };
        }
    }

}
