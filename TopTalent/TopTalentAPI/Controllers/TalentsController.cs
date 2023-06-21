using BussinessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using TopTalentAPI.DTO;

namespace TopTalentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentsController : ControllerBase
    {
        private ITalentRepository repo = new TalentRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Talent>> GetTalent() => repo.GetTalents();

        [HttpGet("id")]
        public IActionResult GetTalentById(int id)
        {
            try
            {
                var talent = repo.GetTalentById(id);
                if (talent == null)
                {
                    return NotFound(new
                    {
                        Success = false,
                        Data = "No have talent id: " + id
                    }
                        );
                }
                return Ok(new
                {
                    Success = true,
                    Date = talent,
                });

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        //
        [HttpPost]
        public IActionResult CreateTalent(TalentVM talent)
        {
            var tmp = repo.CheckUsername(talent.Username);
            if (tmp)
            {
                var talentTmp = new Talent
                {
                    TalentId = talent.TalentId,
                    Username = talent.Username,
                    Password = talent.Password,
                    FullName = talent.FullName,
                    Phone =   int.Parse(talent.Phone),       
                    Address = talent.Address,
                    JobTitle = talent.JobTitle,
                    Price = talent.Price,
                    Description = talent.Description,
                    Image = talent.Image,
                    Status = talent.Status,
                };
                repo.CreateTalent(talentTmp);
                return Ok(new
                {
                    Succes = true,
                    Data = "create talent success"
                });
            }
            else
            {
                return NotFound(new
                {
                    Success = false,
                    Data = "Username is already have"
                });
            }
            return NotFound();

        }


        [HttpDelete]
        public IActionResult DeleteTalent(int id)
        {
            var p = repo.GetTalentById(id);
            if (p == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Data = "No have talent id: " +id
                });
            }
            repo.DeleteTalent(p);
            return Ok(new
            {
                Success = true,
                Data = "Delete talent success"
            });
        }

        [HttpPut("id")]
        public IActionResult UpdateTalent(int id, TalentVM talent)
        {
            var tmp = repo.CheckUsername(talent.Username);
            if (tmp)
            {
                var p = repo.GetTalentById(id);
                if (p != null)
                {
                    p.Username = talent.Username;
                    p.Password = talent.Password;
                    p.FullName = talent.FullName;
                    p.Phone = int.Parse(talent.Phone);
                    p.Address = talent.Address;
                    p.JobTitle = talent.JobTitle;
                    p.Price = talent.Price;
                    p.Description = talent.Description;
                    p.Image = talent.Image;
                    p.Status = talent.Status;

                    repo.UpdateTalent(p);
                    return Ok(new
                    {
                        Success = true,
                        Data = "Update talent success"
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        Success = false,
                        Data = "username already have "
                    });
                }
            }
          

            return NotFound(new
            {
                Success = false,
                Data = "Update talent fail"
            });
        }

    }
}

