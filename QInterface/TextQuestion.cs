using System;
namespace QInterface
{
    public class TextQuestion : Question
    {
        public TextQuestion(string questionText, IQuestionPlatform platform) : base(questionText, platform) { }

        public override void Ask()
        {
            platform.AskQuestion(QuestionText);
            Answer = platform.GetAnswer();
            Console.WriteLine($"Відповідь користувача: {Answer}");
        }
    }
}

