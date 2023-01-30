using System;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Votes();
            post.setPostAttributes();
            Console.WriteLine("Current vote value is: " + post.Calculate());
        }
    }
}
