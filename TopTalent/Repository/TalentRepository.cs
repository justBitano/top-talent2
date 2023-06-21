using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TalentRepository : ITalentRepository
    {
        public bool CheckUsername(string username) => TalentDAO.CheckUsername(username);
     

        public void CreateTalent(Talent talent) => TalentDAO.CreateTalent(talent);


        public void DeleteTalent(Talent talent)=> TalentDAO.DeleteTalent(talent);
        

        public Talent GetTalentById(int id) => TalentDAO.GetTalentById(id);


        public List<Talent> GetTalents() => TalentDAO.GetTalents();


        public void UpdateTalent(Talent talent) => TalentDAO.UpdateTalent(talent);

        public Talent CheckLogin(string username, string password) => TalentDAO.CheckLogin(username, password);

    }
}
