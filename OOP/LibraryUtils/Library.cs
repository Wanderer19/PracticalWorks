using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.LibraryUtils
{
    public class Library
    {
        private readonly List<Magazine> magazines;

        public Library()
        {
            magazines = new List<Magazine>();
        }

        public IEnumerable<Magazine> GetMagazinesWithName(string name)
        {
            return magazines.Where(magazine => magazine.Name == name);
        }

        public IEnumerable<Magazine> GetMagazinesWithYear(int year)
        {
            return magazines.Where(magazine => magazine.Release.Year == year);
        }

        public Magazine GetMagazine(int year, int month, string name)
        {
            //если условие в скобках выполнено для какого то элемента из массива, то первый из них вернется, иначе вернет Null
            return magazines.FirstOrDefault(magazine => magazine.Release.Year == year && magazine.Release.Month == month && magazine.Name == name);
        }

        public void AddMagazine(Magazine magazine)
        {
            //если хоть для какого-то из элементов списка выполнено условие в скобках, то все выражение вернет true
            if (magazines.Any(m => m.Name == magazine.Name && m.Release.Year == magazine.Release.Year && m.Release.Month == magazine.Release.Month))
            {
                throw new InvalidOperationException("Такой журнал уже есть в библиотеке");
            }

            magazines.Add(magazine);
        }
    }
}
