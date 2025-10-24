namespace KH2AiTutor.Client.Helpers
{
    public record TrapHrefNode(
        IEnumerable<HrefAndDisplay> References,
        string Display,
        IEnumerable<TrapHrefNode> Children)
    {
    }
}
