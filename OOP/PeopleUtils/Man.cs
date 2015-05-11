using System;

namespace OOP.PeopleUtils
{
    public class Man
    {
        //автоматические свойства, в которых установка и получение значений может быть произведена и вне данного класса, так как
        // не указаны модификаторы доступа (по умолчанию публичные)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Man(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void GoToSleep()
        {
            Console.WriteLine("Я пошел спать");
        }

        public void WakeUp()
        {
            Console.WriteLine("Я проснулся");
        }
    }
}
