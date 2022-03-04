using Exercise_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comment comment = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome");

            Post post = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zeland",
                "I'm going to visit this wonderfull country!",
                12
                );
            post.AddComment(comment);
            post.AddComment(comment2);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May tthe Foce be with you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            post2.AddComment(comment3);
            post2.AddComment(comment4);


            Console.WriteLine(post);
            Console.WriteLine(post2);


        }
    }
}
