using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;


namespace RepositoryLayer.Service
{
    public class RegisterHelloRL
    {
        ResponseModel<LoginDTO> response;
        private string databaseUsername = "root";
        private string databasePassword = "root";
        public RegisterHelloRL()
        {

        }
        public string GetHello(string name)
        {
            return name+" Hello from repository layer ";
        }
        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            loginDTO.username = databaseUsername;
            loginDTO.password=databasePassword;

            return loginDTO;

        }
    }
}
