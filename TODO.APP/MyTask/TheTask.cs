using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.ViewManagement;

namespace MyTask
{
    public sealed class TheTask:IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
           //This is where you write your task code. 
            int a = 10, b=20;
            int z = a + b;
            //Write to file... 
        }
    }
}
