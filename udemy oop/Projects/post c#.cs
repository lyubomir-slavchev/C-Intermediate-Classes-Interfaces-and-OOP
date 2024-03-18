using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Program
    {
        public class Post {
            private string _title;
            private string _description;
            private DateTime _date { get; set; }
            private int _vote = 0;

            public int Vote
            {
                get { return _vote; }
            }
            public string Title {
                get { return _title; }
                set { _title = value; }
            }

            public string Description {
                get { return _description; }        
                set { _description = value; }   
            }

            public Post(string title, string description, DateTime date)
            {
                _title = title;
                _description = description;
                _date = date;
                
            }

            public void UpVote() { 
                _vote++;
            }
            public void DownVote()
            {
                _vote--;
            }
        }



        static void Main(string[] args)
        {
            var post = new Post("Title","My description",new DateTime(2023,1,1));
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Vote);
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine(post.Vote);
        }
    }
}