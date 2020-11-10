using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_2ClassesEx2
{
    class Post
    {
        public Post() { }

        public Post(string title, string description, DateTime dateCreated)
        {
            this.Title = title;
            this.Description = description;
            this.DateCreated = dateCreated;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; private set; } = DateTime.Now;

        public int Votes { get; private set; } = 0;

        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }
    }
}
