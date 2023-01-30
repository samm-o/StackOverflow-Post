using System;

namespace StackOverflow_Post
{
    class Post
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime datePublished { get; set; }
        public int upVotes { get; set; }
        public int downVotes { get; set; }

        public void setPostAttributes()
        {
            Console.Write("Set post title: ");
            title = Console.ReadLine();
            Console.Clear();

            Console.Write("Set post description: ");
            description = Console.ReadLine();

            Console.Clear();
            datePublished = DateTime.Now;

            if (string.IsNullOrEmpty(title) == true)
            {
                title = "NA";
            }
            if (string.IsNullOrEmpty(description) == true)
            {
                description = "NA";
            }

            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine("Date published: " + datePublished);
        }

        public void Votes()
        {
            Console.WriteLine("Type \"u\" to upvote and \"d\" to downvote this post, then to finish post click enter: ");
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "u")
                {
                    upVotes++;
                }
                if (input == "d")
                {
                    downVotes++;
                }
                if (string.IsNullOrEmpty(input) == true)
                {
                    Console.Clear();
                    break;
                }
            }

        }
        public int Calculate()
        {
            return upVotes - downVotes;
        }
    }
}
