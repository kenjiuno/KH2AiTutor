namespace KH2AiTutorWeb.Helpers
{
    public record HrefAndDisplayGroup(
        string Display,
        IEnumerable<HrefAndDisplay> Links)
    {
    }
}
