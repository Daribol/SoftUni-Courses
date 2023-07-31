using System;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] articles = Console.ReadLine().Split(", ").ToArray();
                string title = articles[0];
                string content = articles[1];
                string author = articles[2];
                Article article = new Article(title, content, author);

                Console.WriteLine($"{title} - {content}: {author}");
            }
        }
    }
}
