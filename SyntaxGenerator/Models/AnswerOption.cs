namespace SyntaxGenerator.Models
{
    public class AnswerOption
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public string? Feedback { get; set; }
        public int PointsPercent { get; set; }

        public AnswerOption(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public AnswerOption(string text, bool isCorrect, int pointspercent)
        {
            Text = text;
            IsCorrect = isCorrect;
            PointsPercent = pointspercent;
        }

        public AnswerOption(string text, bool isCorrect, string feedback)
        {
            Text = text;
            IsCorrect = isCorrect;
            Feedback = feedback;
        }

        public AnswerOption(string text, bool isCorrect, string feedback, int points)
        {
            Text = text;
            IsCorrect = isCorrect;
            Feedback = feedback;
            PointsPercent = points;
        }
    }
}