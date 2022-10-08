using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Exercise_2
{
    internal class Post
    {
        private string Title;
        private string Description;
        private DateTime CreationDateTime;
        private int VoteValue;
        private int UpVotes; //DOESN'T NEED TO BE A FIELD
        private int DownVotes; //DOESN'T NEED TO BE A FIELD

        internal Post()
        {
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.CreationDateTime = DateTime.Now;
            this.VoteValue = 0;

        }

        internal void CommandList()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("The commands for this program are:");
            Console.WriteLine("NAME / UPVOTE / DOWNVOTE / COUNT / PREVIEW");
            Console.WriteLine();
            Console.WriteLine("NAME = Declare Title & Description of Post (can be used for editing also)");
            Console.WriteLine("UPVOTE = Declare value of Up-Votes, this can be incremented multiple times");
            Console.WriteLine("DOWNVOTE = Declare value of Down-Votes, this can be incremented multiple times");
            Console.WriteLine("COUNT = Display the current net value of votes");
            Console.WriteLine("PREVIEW = Preview the post");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("To show these commands again, please type COMMANDS");
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        internal void NameAndDescribePost()
        {
            Console.WriteLine($"Please enter a \"TITLE\" for your Post.");
            this.Title = Console.ReadLine();
            Console.WriteLine($"Please enter a \"DESCRIPTION\" of your Post.");
            this.Description = Console.ReadLine();
        }

        internal void UpVotePost()
        {
            Console.WriteLine($"How many Up-Votes would you like to give this post?");
            this.UpVotes = Convert.ToInt32(Console.ReadLine());
            this.VoteValue += this.UpVotes;
        }

        internal void DownVotePost()
        {
            Console.WriteLine($"How many Down-Votes would you like to give this post?");
            this.DownVotes = Convert.ToInt32(Console.ReadLine());
            this.VoteValue -= this.DownVotes;
        }

        internal void DisplayCurrentVoteValue()
        {
            Console.WriteLine($"The current Vote value of this post is: {VoteValue}");
        }

        internal void PreviewPost()
        {
            Console.WriteLine($"Post Title: {this.Title}");
            Console.WriteLine($"Post Description: {this.Description}");
            Console.WriteLine($"Created on: {this.CreationDateTime}");
            Console.WriteLine($"Down-Votes: {this.VoteValue}"); //CHANGE NAME

        }
    }
}
