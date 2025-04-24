namespace Intermediate_Excercises.Models
{
    //Q#2 Simulating how the votes on post of stackoverflow works 
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; }
        public int votecount;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
            votecount = 0;
        }

        public int Votecount { get { return votecount; } }

        public void UpVote()
        {
            votecount++;
        }
        //
        public void DownVote()
        {
            votecount--;
        }
    }
}
