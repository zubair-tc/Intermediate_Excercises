using Intermediate_Excercises.Models;
using Intermediate_Excercises.Models.Behaviour;

namespace Intermediate_Course
{
    class Program
    {
        static void Main()
        {
            var post = new Post("Work", "At Software house");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine($"Title: {post.Title}\n Description:{post.Description}\n Vote:{post.votecount} ");
        
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            var workflow = new WorkFlow();
            workflow.AddActivity(new UploadVideoActivity());
            workflow.AddActivity(new UploadAudioActivity());

            var engine = new Workflow_Engine();
            engine.Run(workflow);

            var obj = new StopWatch();

            while (true)
            {
                Console.WriteLine("Enter command(start/stop/reset/exit):");
                var input = Console.ReadLine();

                try
                {
                    switch (input.ToLower())
                    {
                        case "start":
                            obj.Start();
                            Console.WriteLine("Stopwatch Started");
                            break;
                        case "stop":
                            obj.Stop();
                            Console.WriteLine("Stopwatch Stop");
                            Console.WriteLine($"Total Duration {obj.Duration.Seconds} seconds");
                            break;
                        case "reset":
                            obj.Stop();
                            Console.WriteLine("Stopwatch Reseted");
                            break;
                        case "exit":
                            return;
                        default:
                            Console.WriteLine("Invalid Command");
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
}
