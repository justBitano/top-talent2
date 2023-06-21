using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class TalentDAO
    {
        public static List<Talent> GetTalents()
        {
            var listTalent = new List<Talent>();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    listTalent = context.Talents.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listTalent;
        }


        public static Talent CheckLogin(string username, string password)
        {
            Talent talent1 = new Talent();
            try
            {

                using (var context = new TopTalent2Context())
                {
                    talent1 = context.Talents.SingleOrDefault(x => x.Username == username && x.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return talent1;
        }
        public static Talent GetTalentById(int talentId)
        {
            Talent talent = new Talent();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    talent = context.Talents.SingleOrDefault(x => x.TalentId == talentId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return talent;
        }
        public static void CreateTalent(Talent talent)
        {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    context.Talents.Add(talent);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateTalent(Talent talent)
        {
            try
            {

                using (var context = new TopTalent2Context())
                {
                    context.Entry<Talent>(talent).State =
                        Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Boolean CheckUsername(string username)
        {
            try
            {
                var user = new User();
                var talent = new Talent();
                using (var context = new TopTalent2Context())
                {
                    user = context.Users.SingleOrDefault(u => u.Username == username);
                    talent = context.Talents.SingleOrDefault(t => t.Username == username);
                    if (user == null && talent == null)
                    {
                        return true;
                    }
                }

                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteTalent(Talent talent)
        {
            try
            {
                var p1 = new Talent();
                using (var context = new TopTalent2Context())
                {
                     p1 = context.Talents.SingleOrDefault(
                        c => c.TalentId == talent.TalentId
                        );
                    context.Talents.Remove(p1);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}


