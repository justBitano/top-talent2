using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Repository;
using TopTalentAPI.DTO;

namespace TopTalentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserRepository repo = new UserRepository();
        private ITalentRepository repoTalent = new TalentRepository();

        [HttpPost("admin")]
        public IActionResult CheckLoginAdmin(LoginVM account)
        {
            if (account.username.IsNullOrEmpty() || account.password.IsNullOrEmpty())
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "username or password is required"
                });
            }
            if(account.username.Equals("admin") && account.password.Equals("admin"))
            {
                return Ok(new
                {
                    Success = true,
                    Message = "Admin Login Success "
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = false,
                    Message = "username or password is invalid"
                });
            }
          


        }
        [HttpPost("user")]
        public IActionResult CheckLoginUser(LoginVM account)
        {
            if (account.username.IsNullOrEmpty() || account.password.IsNullOrEmpty())
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "username or password is required"
                });
            }
            var user = repo.CheckLogin(account.username, account.password);

            if(user == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "username or password is invalid"
                });
            }
            else
            {
                return Ok(new
                {
                    Success = true,
                    Message = "User Login Success"
                });
            }
           

        }
        [HttpPost("talent")]
        public IActionResult CheckLoginTalent(LoginVM account)
        {
            if (account.username.IsNullOrEmpty() || account.password.IsNullOrEmpty())
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "username or password is required"
                });
            }
            var talent = repoTalent.CheckLogin(account.username, account.password);

            if (talent == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "username or password is invalid"
                });
            }
            else
            {
                return Ok(new
                {
                    Success = true,
                    Message = "Talents Login Success"
                });
            }



        }






    }
}
