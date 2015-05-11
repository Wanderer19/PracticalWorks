namespace OOP.LibraryUtils
{
    public class Article
    {
        //автоматические свойства, в которых установка и получение значений может быть произведена и вне данного класса, так как
        // не указаны модификаторы доступа (по умолчанию публичные)
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

        public Article(string title, string text, string author)
        {
            Title = title;
            Text = text;
            Author = author;
        }

        //переопределение метода Equals базового класс object
        public override bool Equals(object other)
        {
            var second = (Article) other;
            return Text.Equals(second.Text) && Author.Equals(second.Author) &&
                   Title.Equals(second.Title);
        }
    }
}
