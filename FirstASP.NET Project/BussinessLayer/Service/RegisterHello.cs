using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Service;

namespace BussinessLayer.Service
{
    public class RegisterHelloBL
    {
        RegisterHelloRL _registerHelloRL;

        public RegisterHelloBL()
        { 
            _registerHelloRL = new RegisterHelloRL();
        }
        public string registration(string name) 
        {
            return "This is bussiness layer data = " +_registerHelloRL.GetHello(name);
        }


    }
}
