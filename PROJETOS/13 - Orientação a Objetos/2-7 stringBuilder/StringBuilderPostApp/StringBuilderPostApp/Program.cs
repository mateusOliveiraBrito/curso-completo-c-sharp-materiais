using StringBuilderPostApp.Entities;
using System;

namespace StringBuilderPostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that' awesome!");

            Post post1 = new Post() {
                Moment = DateTime.Parse("21/06/2020 13:05:44"),
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Likes = 12
            };

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Console.WriteLine(post1);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the force be with you");

            Post post2 = new Post()
            {
                Moment = DateTime.Parse("28/07/2020 23:14:19"),
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5
            };

            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post2);
        }
    }
}
