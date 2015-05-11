using System;
using System.Collections.Generic;

namespace OOP.LibraryUtils
{
    public class Magazine
    {
        //автоматические свойства, в которых установка и получение значений может быть произведена и вне данного класса, так как
        // не указаны модификаторы доступа (по умолчанию публичные)
        public DateTime Release { get; set; }
        public string Name { get; set; }
        public List<Article> Articles;
 
        public Magazine(string name, DateTime release)
        {
            Release = release;
            Name = name;
            Articles = new List<Article>();
        }

        //2-й перегруженный конструктор
        //можно перегружать методы и конструкторы, то есть название одно и то же, но разный набор и колличества аргументов
        public Magazine(string name, DateTime release, List<Article> articles)
        {
            Release = release;
            Name = name;
            this.Articles = articles;
        }

        public void AddArticle(Article article)
        {
            Articles.Add(article);
        }
    }
}
