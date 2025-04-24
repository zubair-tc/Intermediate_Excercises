namespace Intermediate_Excercises.Models
{
    internal class Workflow_Engine
    {
        public void Run(WorkFlow wf)
        {
            foreach (var activity in wf.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
