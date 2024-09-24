using System;
namespace QInterface
{
    public class WebPlatform : IQuestionPlatform
    {
        private static Random random = new Random();

        public void AskQuestion(string questionText)
        {
            Console.WriteLine($"<input type='text' placeholder='{questionText}'>");
        }

        public string GetAnswer()
        {
            return random.Next(0, 100).ToString();
        }
    }
}

