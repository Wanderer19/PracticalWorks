using System;

namespace OOP.PeopleUtils
{
    public class Developer :Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Developer(string firstName, string lastName, int age, string programmingLanguage, double salary)
            : base(firstName, lastName, age, salary)//вызов родительского конструктора, в данном случае вызов конструктора класса Employee
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public double GetPrize()
        {
            //вызов родительского метода GetSalary(принадлежит классу Employee)
            return base.GetSalary()/2 + 1;
        }

        public void WriteCode()
        {
            Console.WriteLine("Я пишу код на {0}", ProgrammingLanguage);
        }
    }
}
