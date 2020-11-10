using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_2ClassesEx2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Post post = new Post();
            post.Title = "Test Post";
            post.Description = "abcdefg test post description";

            Console.WriteLine(post.DateCreated);

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine(post.Votes);


        }
    }
}
