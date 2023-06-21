/*using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using TopTalentAPI.DTO;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace TopTalentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IUserRepository _repo = new UserRepository();
        private readonly AppSetting _appSettings;
      *//*  private TopTalent2Context _context = new TopTalent2Context();*//*

        public AuthController( IOptionsMonitor<AppSetting> optionsMonitor)
        {
          *//*  _context = context;*//*
            _appSettings = optionsMonitor.CurrentValue;
        }
        [HttpPost("login/user")]
        public async Task<IActionResult> Login(string username, string password)
        {
            // TODO: Kiểm tra thông tin đăng nhập của người dùng
            var user = _repo.CheckLogin(username, password);
            if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return NotFound(new
                {
                    Success = false,
                    Data = "Need to enter username or password"
                });
            }
            if (user == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Data = "username or password invalid"
                });
            }
            // Nếu thông tin đúng, tạo JWT

            var token = await GenerateJwtToken(user);

            return Ok(new
            {
                Success = true,
                Message = "Authenticate success",
                Data = token
            });
        }

        private async Task<TokenModel> GenerateJwtToken(User user)
        {
            var jwtTokentHandler = new JwtSecurityTokenHandler();

            var secretKey = Encoding.UTF8.GetBytes(_appSettings.SecretKey);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Username", user.Username),
                    new Claim("Id", user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Username),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                    new Claim(ClaimTypes.Role, user.Status.ToString())

                    //role

                *//*    new Claim("TokenId", Guid.NewGuid().ToString())*//*
                }),
                Expires= DateTime.UtcNow.AddSeconds(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey
                    (secretKey), SecurityAlgorithms.HmacSha256Signature)



            };
         
            var token = jwtTokentHandler.CreateToken(tokenDescription);
            var accessToken = jwtTokentHandler.WriteToken(token);
            var refreshToken = GenerateRefreshToken();
            Guid guid = new Guid();
            //Luu database
            var refreshTokenEntity = new RefershTokenUser
            {
                RefershToken = guid.GetHashCode(),
                JwtId = token.Id,
                Token = refreshToken,
                IsUsed = false,
                IsRevoked = false,
                IssuedAt = DateTime.UtcNow,
                ExpiredAt = DateTime.UtcNow.AddHours(1)
            };

            TopTalent2Context _context = new TopTalent2Context();
            await _context.AddAsync(refreshTokenEntity);
            await _context.SaveChangesAsync();

            return new TokenModel
            {
                accessToken = accessToken,
                refershToken = GenerateRefreshToken()
            };


        }
    

        private string GenerateRefreshToken()
        {
            var random = new byte[32];
            using(var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
                return Convert.ToBase64String(random);
            }
        }
        [HttpPost("RenewToken")]
        public async Task<IActionResult> RenewToken(TokenModel model)
        {
            TopTalent2Context _context = new TopTalent2Context();
            var jwtTokentHandler = new JwtSecurityTokenHandler();

            var secretKey = Encoding.UTF8.GetBytes(_appSettings.SecretKey);
            var tokenValidateParam = new TokenValidationParameters
            {
                //tu cap token
                ValidateIssuer = false,
                ValidateAudience  =false,

                //ky vao token
                ValidateIssuerSigningKey = true,
                IssuerSigningKey =  new SymmetricSecurityKey(secretKey),

                ClockSkew  = TimeSpan.Zero,
                ValidateLifetime = false //ko kiem tra token het han
            };
            try
            {
                //check 1: AccessToken valid format
                var tokenInVerification = jwtTokentHandler.ValidateToken(model.accessToken, tokenValidateParam, out var validatedToken);
                //check 2: alg

                if(validatedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals
                        (SecurityAlgorithms.HmacSha512,
                        StringComparison.InvariantCultureIgnoreCase);
                    if (!result)
                    {
                        return Ok(new
                        {
                            Success = false,
                            Message = "Invalid token"
                        });
                    }
                }
                //check 3: check accessToken expire?
                var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(
                    x => x.Type == JwtRegisteredClaimNames.Exp).Value);

                var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
                if(expireDate > DateTime.UtcNow)
                {
                    return Ok(new
                    {
                        Success = false,
                        Message = "Access Token has not yet expired"
                    });

                }
                //check 4: check refershToken exist in Db
                var storedToken = _context.RefershTokenUsers.FirstOrDefault(x => x.Token == model.refershToken);
                if(storedToken == null)
                {
                    return Ok(new
                    {
                        Success = false,
                        Message = "RefershToken does not exist"
                    });
                }

                //check 5: check refreshToken đã used chưa
                if ((bool)storedToken.IsUsed)
                {
                    return Ok(new
                    {
                        Success = false,
                        Message = "RefreshToken has been used"
                    });
                }

                if ((bool)storedToken.IsRevoked)
                {
                    return Ok(new
                    {
                        Success = false,
                        Message = "RefreshToken has been revoked"
                    });
                }

                //check 6: AccessToken id == jwtId is refersh Token
                var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type ==
                JwtRegisteredClaimNames.Jti).Value;
                if(storedToken.JwtId != jti)
                {
                    return Ok(new
                    {
                      Success = false,
                      Message = "Token doesnt match"
                    });
                }
                //Update token  is used
                storedToken.IsRevoked = true;
                storedToken.IsUsed = true;
                _context.Update(storedToken);
                await _context.SaveChangesAsync();

                //Create new token
                var user = await _context.Users.SingleOrDefaultAsync( user => 
                user.UserId == storedToken.UserId );    
                var token = await GenerateJwtToken(user);
                return Ok(new
                {
                    Success = true,
                    Message = "Renew Token Success",
                    Data = token
                });
                
               

            }catch(Exception ex)
            {
                return BadRequest(new
                {
                    Success = false,
                    Message = "Something went wrong",
                });
            }
        }

        private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();
            return dateTimeInterval;
        }

        [HttpGet("test")]
        [Authorize] // Áp dụng ủy quyền cho phương thức này
        public IActionResult Test()
        {
            // Phương thức này chỉ được gọi nếu người dùng đã xác thực và có JWT hợp lệ
            // Xử lý logic tại đây

            return Ok(new
            {
                Success = true,
                Data = "Bạn dc ủy quyền làm việc này"
            });
        }
    }
}
*/