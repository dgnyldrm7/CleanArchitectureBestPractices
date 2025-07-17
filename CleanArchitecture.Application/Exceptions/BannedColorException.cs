namespace CleanArchitecture.Application.Exceptions
{
    public class BannedColorException : Exception
    {
        public BannedColorException(string color) : base($"The color '{color}' is banned and cannot be used.")
        {
            Color = color;
        }
        public BannedColorException(string color, Exception innerException) : base($"The color '{color}' is banned and cannot be used.", innerException)
        {
            Color = color;
        }
        public string Color { get; set; } = default!;
    }
}