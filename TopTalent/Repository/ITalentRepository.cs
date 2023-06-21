using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITalentRepository
    {
        void CreateTalent(Talent talent);

        
        Talent GetTalentById(int id);

        void DeleteTalent(Talent talent);

        void UpdateTalent(Talent talent);

        List<Talent> GetTalents();

        Boolean CheckUsername(string username);

        Talent CheckLogin(string username, string password);
    }
}
