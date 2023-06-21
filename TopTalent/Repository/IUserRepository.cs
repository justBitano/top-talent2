using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {

        void CreateUser(User user);

        User GetUserById(int id);

        void DeleteUser(User user);

        void UpdateUser(User user);

        List<User> GetUsers();

    
        Boolean CheckUsername(string username);

        User CheckLogin(string username, string password);
    }
}
