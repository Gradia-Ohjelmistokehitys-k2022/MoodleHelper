namespace SyntaxGenerator.Models
{
    public class AnswerOption
    {
        public string Text { get; set; }
        public string? Feedback { get; set; }
        public int PointsPercent { get; set; }

        public AnswerOption(string text)
        {
            Text = text;
        }

        public AnswerOption(string text, int pointspercent)
        {
            Text = text;
            PointsPercent = pointspercent;
        }

        public AnswerOption(string text, string feedback)
        {
            Text = text;
            Feedback = feedback;
        }

        public AnswerOption(string text, string feedback, int points)
        {
            Text = text;
            Feedback = feedback;
            PointsPercent = points;
        }
    }
}