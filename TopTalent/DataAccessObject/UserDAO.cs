using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class UserDAO
    {
        public static List<User> GetUser()
        {
            var listUser = new List<User>();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    listUser = context.Users.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listUser;
        }
        public static User CheckLogin(string username, string password)
        {
            User user1 = new User();
            try
            {
               
                {
                    using (var context = new TopTalent2Context())
                    {
                        user1 = context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
                    }
                }
                
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user1;
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
                    if(user == null && talent == null)
                    {
                        return true;
                    }
                }

                return false;

            }catch(Exception ex ) {
                throw new Exception(ex.Message);
                    }
        }
       
        public static User GetUserById(int userID)
        {
            User u = new User();
            try
            {
                using (var context = new TopTalent2Context())
                {
                    u = context.Users.SingleOrDefault(x => x.UserId == userID);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return u;
        }

        public static void CreateUser(User user)
        {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    context.Users.Add(user);
                    context.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateUser(User user)
        {
            try
            {

                using (var context = new TopTalent2Context())
                {
                    context.Entry<User>(user).State =
                        Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteUser(User user) {
            try
            {
                using (var context = new TopTalent2Context())
                {
                    var p1 = context.Users.SingleOrDefault(
                        c => c.UserId == user.UserId
                        );
                    context.Users.Remove(p1);
                    context.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
