using System;
using System.Text;

namespace Exercise2
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _timeOfPost;
        private int _numberOfVotes;
        private StringBuilder _mainPost = new StringBuilder();

        public Post(string title, string description, DateTime dateTime, int voteNumber)
        {
            this.myTitle = title;
            this.myDescription = description;
            this.myTimeOfPost = dateTime;
            this.myNumberOfVotes = voteNumber;
        }


        public string myTitle 
        {
            get 
            { 
                return _title; 
            }
            set 
            {
                _title = value;
            } 
        }
        public string myDescription
        {
            get 
            { 
                return _description; 
            }
            set 
            {
                _description = value;
            } 
        }
        public DateTime myTimeOfPost
        {
            get
            {
                return _timeOfPost;
            }
            set
            {
                _timeOfPost = value;
            }
        }
        public int myNumberOfVotes
        {
            get
            {
                return _numberOfVotes;
            }
            set
            {
                _numberOfVotes = value;
            }
        }
       

        public void DisplyPost()
        {
            _mainPost.Append('-', _title.Length);
            _mainPost.AppendLine();
            _mainPost.Append(_title);
            _mainPost.AppendLine();
            _mainPost.Append('-', _title.Length);
            _mainPost.AppendLine();
            _mainPost.AppendLine();
            _mainPost.Append(_description);
            _mainPost.AppendLine();
            _mainPost.Append('-', _description.Length);
            _mainPost.AppendLine();
            _mainPost.Append("Created "+ _timeOfPost + " | Number of Votes: " + _numberOfVotes);
            Console.WriteLine(_mainPost);
            
        }

        public void ChangeVote(string voteChoice)
        {
            if (voteChoice == "UP")
            {
                _numberOfVotes++;
                Console.WriteLine(" ");
            }
            else if (voteChoice == "DOWN")
            {
                _numberOfVotes--;
                Console.WriteLine(" ");
            }
            
        }
    }
}
