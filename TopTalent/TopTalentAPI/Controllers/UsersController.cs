
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using TopTalentAPI.DTO;

namespace TopTalentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private IUserRepository repo = new UserRepository();


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers() => repo.GetUsers();

        [HttpGet("id")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = repo.GetUserById(id);
                if (user == null)
                {
                    return NotFound(new
                    {
                        Success = false,
                        Data = "No have user id: " + id
                    }
                        );
                }
                return Ok(new
                {
                    Success = true,
                    Date = user,
                });

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        //
        [HttpPost]
        public IActionResult CreateUser(UserVM user)
        {
            try
            {
                var tmp = repo.CheckUsername(user.Username);
                if (tmp)
                {
                    var userTmp = new User
                    {
                        UserId = user.UserId,
                        Username = user.Username,
                        Password = user.Password,
                        FullName = user.FullName,
                        Phone = int.Parse(user.Phone),
                        Description = user.Description,
                        Image = user.Image,
                        Status = user.Status,
                    };
                    repo.CreateUser(userTmp);
                    return Ok(new
                    {
                        Succes = true,
                        Data = "create user success"
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        Success = false,
                        Data = "username is already have"
                    });
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }


        }



        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var p = repo.GetUserById(id);
            if (p == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Data = "No have user id: " +id
                });
            }
            repo.DeleteUser(p);
            return Ok(new
            {
                Success = true,
                Data = "Delete user success"
            }

                );
        }

        [HttpPut("id")]
        public IActionResult UpdateUser(int id, UserVM user)
        {
            var tmp = repo.CheckUsername(user.Username);
            if (tmp)
            {
                var p = repo.GetUserById(id);
                if (p != null)
                {
                    p.Username = user.Username;
                    p.Password = user.Password;
                    p.FullName = user.FullName;
                    p.Phone =   int.Parse(user.Phone);
                    p.Description = user.Description;
                    p.Image = user.Image;
                    p.Status = user.Status;

                    repo.UpdateUser(p);
                    return Ok(new
                    {
                        Success = true,
                        Data = "Update user success"
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        Success = false,
                        Data = "username is already have"
                    });
                }
            }


            return NotFound();
        }



    }
}
