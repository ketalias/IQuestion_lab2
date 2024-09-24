using System;
namespace QInterface
{
    public class iOSPlatform : IQuestionPlatform
    {
        public void AskQuestion(string questionText)
        {
            Console.WriteLine("Помилка iOS: Ще не реалізовано.");
        }

        public string GetAnswer()
        {
            Console.WriteLine("Помилка iOS: Ще не реалізовано.");
            return string.Empty;
        }
    }
}

