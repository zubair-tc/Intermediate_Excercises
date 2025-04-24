using Intermediate_Excercises.Interface;

namespace Intermediate_Excercises.Models.Behaviour
{
    internal class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video");
        }
    }
}
