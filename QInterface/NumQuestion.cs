using System;
namespace QInterface
{
    public class NumberQuestion : Question
    {
        public NumberQuestion(string questionText, IQuestionPlatform platform) : base(questionText, platform) { }

        public override void Ask()
        {
            platform.AskQuestion(QuestionText);
            Answer = platform.GetAnswer();
            if (int.TryParse(Answer, out int number))
            {
                Console.WriteLine($"Відповідь користувача (число): {number}");
            }
            else
            {
                Console.WriteLine("Відповідь не є числом.");
            }
        }
    }
}

