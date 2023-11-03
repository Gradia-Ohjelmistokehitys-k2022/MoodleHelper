using SyntaxGenerator.Models;

namespace SyntaxGenerator
{
    public class SyntaxGen
    {
        public SyntaxGen()
        {
            
        }

        
        private static string CreateNumerical(decimal correctAnswer, decimal marginal = 0, int points = 1)
        {
            string question = "{";
            question += $"{points}:NUMERICAL:={correctAnswer}:{marginal}";
            return question += "}";
        }
        
        
        private static string CreateShortAnswer(bool isCaseSensitive, List<AnswerOption> answers, int points = 1)
        {
            string question = "{";
            question += $"{points}:";
            
            if (isCaseSensitive == true)
            {
                question += "SHORTANSWER_C:";
            }
            
            else
            {
                question += "SHORTANSWER:";
            }
            
            for (int i = 0; i < answers.Count(); i++)
            {
                AnswerOption answer = answers[i];

                if (answer.IsCorrect == true)
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"%100%{answer.Text}";
                    }

                    else
                    {
                        question += $"%100%{answer.Text}#{answer.Feedback}";
                    }
                }

                else
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"{answer.Text}";
                    }

                    else
                    {
                        question += $"{answer.Text}#{answer.Feedback}";
                    }
                }

                if (i != answers.Count())
                {
                    question += "~";
                }
            }

            return question += "}";
        }

        
        private static string CreateMultiChoice(List<AnswerOption> answers, bool isRandomized, bool? isVertical, int points = 1)
        {
            string question = "{";
            question += $"{points}:";
            
            if (isRandomized == true)
            {
                switch (isVertical)
                {
                    case true:
                        question += "MULTICHOICE_VS:";
                        break;

                    case false:
                        question += "MULTICHOICE_HS:";
                        break;

                    default:
                        question += "MULTICHOICE_S:";
                        break;
                }
            }
            
            else
            {
                switch (isVertical)
                {
                    case true:
                        question += "MULTICHOICE_V:";
                        break;

                    case false:
                        question += "MULTICHOICE_H:";
                        break;

                    default:
                        question += "MULTICHOICE:";
                        break;
                }
            }

            for (int i = 0; i < answers.Count(); i++)
            {
                AnswerOption answer = answers[i];

                if (answer.IsCorrect == true)
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"={answer.Text}";
                    }

                    else
                    {
                        question += $"={answer.Text}#{answer.Feedback}";
                    }
                }
                
                else
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"{answer.Text}";
                    }

                    else
                    {
                        question += $"{answer.Text}#{answer.Feedback}";
                    }
                }

                if (i != answers.Count())
                {
                    question += "~";
                }
            }
            
            return question += "}";
        }

        
        private static string CreateMultiResponse(List<AnswerOption> answers, bool isRandomized, bool isVertical, int points = 1)
        {
            string question = "{";
            question += $"{points}:";

            if (isRandomized == true)
            {
                switch (isVertical)
                {
                    case true:
                        question += "MULTIRESPONSE_S:";
                        break;

                    case false:
                        question += "MULTIRESPONSE_HS:";
                        break;
                }
            }

            else
            {
                switch (isVertical)
                {
                    case true:
                        question += "MULTIRESPONSE:";
                        break;

                    case false:
                        question += "MULTIRESPONSE_H:";
                        break;
                }
            }

            for (int i = 0; i < answers.Count(); i++)
            {
                AnswerOption answer = answers[i];

                if (answer.IsCorrect == true)
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"={answer.Text}";
                    }

                    else
                    {
                        question += $"={answer.Text}#{answer.Feedback}";
                    }
                }

                else
                {
                    if (string.IsNullOrWhiteSpace(answer.Feedback))
                    {
                        question += $"{answer.Text}";
                    }

                    else
                    {
                        question += $"{answer.Text}#{answer.Feedback}";
                    }
                }

                if (i != answers.Count())
                {
                    question += "~";
                }
            }

            return question += "}";
        }
    }
}