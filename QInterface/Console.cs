using System;
namespace QInterface
{
    public interface IQuestionPlatform
    {
        void AskQuestion(string questionText);
        string GetAnswer();
    }

    public class ConsolePlatform : IQuestionPlatform
    {
        public void AskQuestion(string questionText)
        {
            Console.WriteLine(questionText);
        }

        public string GetAnswer()
        {
            return Console.ReadLine();
        }
    }
}

