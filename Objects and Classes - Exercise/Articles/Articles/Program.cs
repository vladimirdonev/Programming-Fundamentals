using System;
using System.Linq;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pepar = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string title = pepar[0];
            string content = pepar[1];
            string autor = pepar[2];
            Articles articles = new Articles(title, content, autor);
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n > counter)
            {
                string[] splitedinput = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = splitedinput[0];


                if (command == "Edit")
                {
                    string NewContent = splitedinput[1];
                    articles.Edit(NewContent);

                }
                else if (command == "ChangeAuthor")
                {
                    string NewAutor = splitedinput[1];
                    articles.ChangeAutor(NewAutor);

                }
                else if (command == "Rename")
                {
                    string NewTitle = splitedinput[1];
                    articles.Rename(NewTitle);

                }
                counter++;
            }

            Console.WriteLine(articles);
        }
    }
}
class Articles
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public Articles(string title, string content, string autor)
    {
        this.Content = content;
        this.Author = autor;
        this.Title = title;
    }
    public void Edit(string NewContent)
    {
        this.Content = NewContent;
    }
    public void ChangeAutor(string NewAutor)
    {
        this.Author = NewAutor;
    }
    public void Rename(string NewTitle)
    {
        this.Title = NewTitle;
    }
    public override string ToString()
    {
        return $"{this.Title} - {this.Content}: {this.Author}";
    }
}
