using Intermediate_Excercises.Interface;

namespace Intermediate_Excercises.Models.Behaviour
{
    internal class UploadAudioActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Audio");
        }
    }
}
