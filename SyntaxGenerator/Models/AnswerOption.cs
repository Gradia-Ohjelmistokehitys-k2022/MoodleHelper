using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxGenerator.Models
{
    internal class AnswerOption
    {
        internal string Text { get; set; }
        internal bool IsCorrect { get; set; }
        internal string ?Feedback { get; set; }
        
        internal AnswerOption(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
        
        internal AnswerOption(string text, bool isCorrect, string feedback)
        {
            Text = text;
            IsCorrect = isCorrect;
            Feedback = feedback;
        }
    }
}
