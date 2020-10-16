﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NewsPortal.Common.Models;
using NewsPortal.Common.VM;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Helper
{
    public class GenerateToken : IGenerateToken
    {
        private readonly AppSettings _appSettings;

        public GenerateToken(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public async Task<LoginReturn> BuildToken(LoginReturn loginReturn)
        {

            string UserName = "UserName";
            string id = "UserId";


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                                        new Claim(id, loginReturn.UserId.ToString()),
                                        new Claim(UserName, loginReturn.UserName.ToString()),
                                        new Claim(ClaimTypes.Email, loginReturn.Email.ToString()),
                                        new Claim(ClaimTypes.Role, loginReturn.Role.ToString()),
                                        new Claim(ClaimTypes.Name, loginReturn.Name.ToString()),
                
                
                
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            loginReturn.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            loginReturn.Message = "Success";
            return loginReturn;
        }
    }

    public interface IGenerateToken
    {
        Task<LoginReturn> BuildToken(LoginReturn login);
    }
}
