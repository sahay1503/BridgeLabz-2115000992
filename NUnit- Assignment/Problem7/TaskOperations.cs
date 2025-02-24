using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem7
{
    public class TaskOperations
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);
            return "Task Completed";
        }
    }
}
