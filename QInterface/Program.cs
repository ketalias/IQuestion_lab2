using System;
using System.Collections.Generic;

//Варіант 5. Розробити систему інтерфейсу взаємодії з користувачем.
//Система містить об’єкти Питання, яке може задати користувачу та зберегти відповідь.
//Для одних запитань відповідь може бути тільки рядкового, для інших – цілого типу.
//Система повинна працювати на двох платформах:
//у режимі консолі (питання виводяться в консоль та очікується відповідь)
//та в “Web” режимі – генерується шаблон відповідного елементу
//(наприклад <input type="number" placeholder="питання">який виводиться в консоль,
//а відповідь генерується випадковим чином. Передбачити можливість
//в майбутньому розширення системи. Реалізувати запитання,
//які передбачають вибір одного варіанту зі списку.
//Передбачити можливість взаємодії з користувачем на інших платформах,
//реалізувати заглушки запитань для iOS та Android які
//генерують помилки «Ще не реалізовано».


namespace QInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            IQuestionPlatform consolePlatform = new ConsolePlatform();

            Question textQuestion = new TextQuestion("Як вас звати?", consolePlatform);
            textQuestion.Ask();

            Question numberQuestion = new NumberQuestion("Скільки вам років?", consolePlatform);
            numberQuestion.Ask();

            Question choiceQuestion = new ChoiceQuestion("Який ваш улюблений колір?", new List<string> { "Червоний", "Синій", "Зелений" }, consolePlatform);
            choiceQuestion.Ask();


            IQuestionPlatform webPlatform = new WebPlatform();

            Question webTextQuestion = new TextQuestion("Введіть ваше ім'я:", webPlatform);
            webTextQuestion.Ask();

            Question webNumberQuestion = new NumberQuestion("Скільки вам років?", webPlatform);
            webNumberQuestion.Ask();

            Question webChoiceQuestion = new ChoiceQuestion("Оберіть ваш улюблений колір:", new List<string> { "Червоний", "Синій", "Зелений" }, webPlatform);
            webChoiceQuestion.Ask();


            IQuestionPlatform iosPlatform = new iOSPlatform();
            Question iosQuestion = new TextQuestion("Це iOS питання?", iosPlatform);
            iosQuestion.Ask();
        }
    }
}
