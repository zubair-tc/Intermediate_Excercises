namespace Intermediate_Course
{
    class Program
    {
        //Section 2 Excercise 
        //Q#1 Simulating the Stopwatch 
        public class StopWatch
        {
            private DateTime Start_Time;
            private TimeSpan duration;
            private bool isRunning;

            public void Start()
            {
                if (isRunning)
                    throw new InvalidOperationException("Stopwatch is Already Running");
                Start_Time = DateTime.Now;
                isRunning = true;
            }

            public void Stop()
            {
                if (!isRunning)
                    throw new InvalidOperationException("Stopwatch Stop Running");

                var endtime = DateTime.Now;
                duration = (endtime - Start_Time);
                isRunning = false;
            }

            public TimeSpan Duration { get { return duration; } }

            public void Reset()
            {
                isRunning = false;
                duration = TimeSpan.Zero;
            }

            static void Main()
            {
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

            public void up_Vote()
            {
                votecount++;
            }
            //
            public void down_Vote()
            {
                votecount--;
            }
        }
        static void Main()
        {
            var post = new Post("Work", "At Software house");
            post.up_Vote();
            post.up_Vote();
            post.up_Vote();
            post.down_Vote();
            post.down_Vote();
            Console.WriteLine($"Title: {post.Title}\n Description:{post.Description}\n Vote:{post.votecount} ");
        }
        //Section 4 Excercises 
        //Q#1 
        public class Stack
        {
            private readonly List<object> _elements = new List<object>();

            //push method 
            public void Push(object obj)
            {
                if (obj == null)
                    Console.WriteLine("Cannot push null in the stack");

                _elements.Add(obj);
            }

            //pop method
            public Object Pop()
            {
                if (_elements.Count == 0)
                    Console.WriteLine("Stack is Empty");

                int lastindex = _elements.Count - 1;
                object top = _elements[lastindex];
                _elements.RemoveAt(lastindex);
                return top;
            }

            //clear method
            public void Clear()
            {
                _elements.Clear();
            }

            static void Main()
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
