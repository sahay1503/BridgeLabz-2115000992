using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
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
        public bool loginUser(LoginDTO loginDTO)
        {
            string frontendUsername = loginDTO.username;
            string frontendPassword = loginDTO.password;

            LoginDTO result = _registerHelloRL.getUsernamePassword(loginDTO);

            bool res=checkUsernamePassword(frontendUsername, frontendPassword,result);
            return res;
        }
        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            if (frontendUsername == result.username && frontendPassword==result.password)
            {
                return true;
            }
            return false;
            
        }


    }
}
