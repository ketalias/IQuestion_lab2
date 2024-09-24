using System;
namespace QInterface
{
    public class AndroidPlatform : IQuestionPlatform
    {
        public void AskQuestion(string questionText)
        {
            Console.WriteLine("Помилка Android: Ще не реалізовано.");
        }

        public string GetAnswer()
        {
            Console.WriteLine("Помилка Android: Ще не реалізовано.");
            return string.Empty;
        }
    }
}

