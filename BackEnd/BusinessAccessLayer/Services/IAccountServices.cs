using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services
{
    public interface IAccountServices
    {
        Task<Token> IsLogin(UserLoginDto user);
        Task<string> GetToken(string UserName);
        Task<bool> SignUp(UserSignUpDto user);
    }
}
