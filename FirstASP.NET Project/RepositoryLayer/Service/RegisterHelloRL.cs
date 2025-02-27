using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL
    {
        public RegisterHelloRL()
        {

        }
        public string GetHello(string name)
        {
            return name+" Hello from repository layer ";
        }
    }
}
