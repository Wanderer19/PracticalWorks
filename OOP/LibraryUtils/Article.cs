namespace OOP.Solutions.LibraryUtils
{
    public class Article
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

        public Article(string title, string text, string author)
        {
            Title = title;
            Text = text;
            Author = author;
        }

        public override bool Equals(object other)
        {
            var second = (Article) other;
            return Text.Equals(second.Text) && Author.Equals(second.Author) &&
                   Title.Equals(second.Title);
        }
    }
}
