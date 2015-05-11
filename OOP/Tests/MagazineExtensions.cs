using OOP.LibraryUtils;

namespace OOP.Tests
{
    public static class MagazineExtensions
    {
        public static bool MyEquals(this Magazine first, Magazine second)
        {
            return first.Name.Equals(second.Name) && first.Release.Equals(second.Release) && first.Articles.TrueForAll(art => second.Articles.Contains(art) && first.Articles.Count == second.Articles.Count);
        }
    }
}
