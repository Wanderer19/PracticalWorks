using System;

namespace OOP.PeopleUtils
{
    public class Employee:Man
    {
        private readonly double salary;
        public Employee(string firstName, string lastName, int age, double salary) 
            : base(firstName, lastName, age) //вызов родительского конструктора, в данном случае вызов конструктора класса Man
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary - salary/10;
        }

        public void GoToWork()
        {
            Console.WriteLine("Я пошел работать!");
        }
    }
}
