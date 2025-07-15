namespace CleanArchitecture.Shared.Result
{
    public class ProblemDetails
    {
        public int Status { get; set; } = 500;
        public string Title { get; set; } = "Internal Server Error";
        public string Detail { get; set; } = "An error occurred while processing your request.";
    }
}
