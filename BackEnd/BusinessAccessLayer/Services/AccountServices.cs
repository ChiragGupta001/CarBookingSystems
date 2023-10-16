using AutoMapper;
using Data_Access_Layer.Contacts;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BusinessAccessLayer.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _host;
        public AccountServices(UserManager<User> userManager, SignInManager<User> signInManager, IRepository<User> repository, IConfiguration configuration, IMapper mapper, IHostingEnvironment host)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _repository = repository;
            _configuration = configuration;
            _mapper = mapper;
            _host = host;
        }


        public async Task<Token> IsLogin(UserLoginDto user)
        {
            if (user != null)
            {
                var isExist = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, user.RememberMe, true);
                if (isExist.Succeeded)
                {
                    var token = GetToken(user.UserName);
                    var authToken = new Token();
                    authToken.userToken = await token;
                    return authToken;
                }
            }
            return null;
        }

        public async Task<string> GetToken(string UserName)
        {
            var user = await _userManager.FindByNameAsync(UserName);
            var role = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            List<Claim> claim = new List<Claim>
            {
                new Claim("userName", user.UserName),
                new Claim("role", role[0]),
                new Claim("id", user.Id)
            };
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));
            var cred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken
              (
              _configuration.GetSection("Jwt:Issuer").Value,
              _configuration.GetSection("Jwt:Audience").Value,
              claims: claim,
              expires: DateTime.Now.AddMinutes(90),
              signingCredentials: cred
              );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            //Console.WriteLine(jwt);
            return jwt;
        }

        public async Task<bool> SignUp(UserSignUpDto userDto)
        {
            var isExist = await _userManager.FindByNameAsync(userDto.UserName);
            if (isExist == null)
            {
                var users = new User();
                users.UserName = userDto.UserName;
                users.Password = userDto.Password;
                users.Email = userDto.Email;
                users.Name = userDto.Name;
                users.NormalizedEmail = userDto.Email;
                users.EmailConfirmed = true;
                users.EmailConfirmed = true;
                users.NormalizedUserName = userDto.UserName;
                users.PhoneNumber = userDto.PhoneNumber;
                users.PhoneNumberConfirmed = true;
                users.Profile = await UploadedFile(userDto.Profile);
                var result = await _userManager.CreateAsync(users,userDto.Password);
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(users, "User");
                    return true;
                }
                return false;
            }
            return false;
        }



        public async Task<string> UploadedFile(IFormFile fileUpload)
        {
            try
            {
                if (fileUpload.Length > 0)
                {
                    string path = Path.Combine(_host.WebRootPath + "\\uploads\\");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);

                    }
                    string filePath = Path.Combine(path, fileUpload.FileName);
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await fileUpload.CopyToAsync(fileStream);
                        return "https://localhost:7038/uploads/" + fileUpload.FileName;
                    };
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}