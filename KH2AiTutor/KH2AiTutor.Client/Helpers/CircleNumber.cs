namespace KH2AiTutor.Client.Helpers
{
    public class CircleNumber
    {
        private readonly string _marks = "①②③④⑤⑥➆⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳";

        public string Of(int number)
        {
            if (1 <= number && number <= 20)
            {
                return _marks[number - 1].ToString();
            }
            return $"({number})";
        }
    }
}
