using Intermediate_Excercises.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
