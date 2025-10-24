namespace KH2AiTutor.Client.Helpers
{
    public record HrefAndDisplayGroup(
        string Display,
        IEnumerable<HrefAndDisplay> Links)
    {
    }
}
