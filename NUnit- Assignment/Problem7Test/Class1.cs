using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem7;
namespace Problem7Test
{
    [TestFixture]
    public class Class1
    {
        private TaskOperations _task;

        [SetUp]
        public void Setup()
        {
            _task = new TaskOperations();
        }
        [Test]
        [Timeout(2000)]
        public void LongRunningTask_ShouldFailIfTakesLongerThan2Seconds()
        {
            _task.LongRunningTask();
        }

    }
}
