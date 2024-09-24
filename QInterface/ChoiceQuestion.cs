using System;
namespace QInterface
{
    public class ChoiceQuestion : Question
    {
        private List<string> choices;

        public ChoiceQuestion(string questionText, List<string> choices, IQuestionPlatform platform) : base(questionText, platform)
        {
            this.choices = choices;
        }

        public override void Ask()
        {
            platform.AskQuestion($"{QuestionText} (Виберіть один варіант: {string.Join(", ", choices)})");
            Answer = platform.GetAnswer();

            if (choices.Contains(Answer))
            {
                Console.WriteLine($"Вибрано: {Answer}");
            }
            else
            {
                Console.WriteLine("Невірний вибір.");
            }
        }
    }
}

