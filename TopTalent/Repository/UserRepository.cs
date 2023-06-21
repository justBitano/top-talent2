using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user) => UserDAO.CreateUser(user);



        public void DeleteUser(User user) => UserDAO.DeleteUser(user);


        public User GetUserById(int id) => UserDAO.GetUserById(id);


        public List<User> GetUsers() => UserDAO.GetUser();


        public void UpdateUser(User user) => UserDAO.UpdateUser(user);

         public Boolean CheckUsername(string username) => UserDAO.CheckUsername(username);

        public User CheckLogin(string username, string password) => UserDAO.CheckLogin(username, password);

    }
}
