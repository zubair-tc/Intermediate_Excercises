using Intermediate_Excercises.Interface;

namespace Intermediate_Excercises.Models
{
    internal class WorkFlow
    {
        private readonly List<IActivity> activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return activities;
        }
    }
}
