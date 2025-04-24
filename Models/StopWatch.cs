namespace Intermediate_Excercises.Models
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
        }
}