namespace CleanArchitecture.Application.Services
{
    public class SelectColorService
    {
        private readonly List<string> _bannedColors = new List<string> { "red", "blue", "green" };
        public string SelectColor(string colorName)
        {
            if (_bannedColors.Contains(colorName.ToLowerInvariant()))
            {
                throw new BannedColorException(colorName);
            }
            return colorName;
        }
    }
}
