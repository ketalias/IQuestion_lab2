using System;
namespace QInterface
{
    public abstract class Question
    {
        protected IQuestionPlatform platform;
        public string QuestionText { get; set; }
        public string Answer { get; protected set; }

        public Question(string questionText, IQuestionPlatform platform)
        {
            QuestionText = questionText;
            this.platform = platform;
        }

        public abstract void Ask();
    }
}

