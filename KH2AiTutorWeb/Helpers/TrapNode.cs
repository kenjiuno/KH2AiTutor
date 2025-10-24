namespace KH2AiTutorWeb.Helpers
{
    public record TrapHrefNode(
        IEnumerable<HrefAndDisplay> References,
        string Display,
        IEnumerable<TrapHrefNode> Children)
    {
    }
}
