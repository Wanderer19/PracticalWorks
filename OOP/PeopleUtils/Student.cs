using System;

namespace OOP.PeopleUtils
{
    public class Student : Man
    {
        public string UniversityName { get; set; }
        public Student(string firstName, string lastName, int age, string universityName)
            : base(firstName, lastName, age)//вызов родительского конструктора, в данном случае вызов конструктора класса Man
        {
            UniversityName = universityName;
        }

        public void DoCoursework(string theme)
        {
            Console.WriteLine("Скоро начну....");
        }
    }
}
