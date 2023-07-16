using System;
using System.Linq;
using System.Collections.Generic;

namespace articles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int articlesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleArguments = Console.ReadLine().Split();
                string title = articleArguments[0];
                string content = articleArguments[1];
                string author = articleArguments[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
        }
    }

    public class Article
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

        internal void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        internal void EditContent(string newContent)
        {
            this.Content = newContent;
        }

        internal void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            string result;

            result = $"{Title} - {Content}: {Author}";

            return result;
        }
    }
}