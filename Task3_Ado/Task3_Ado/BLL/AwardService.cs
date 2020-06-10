using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.DAL;
using Task3_Ado.Entities;

namespace Task3_Ado.BLL
{
    class AwardService : IAwardService
    {
        private AwardDAO _awardDAO;
        public AwardService()
        {
           _awardDAO = new AwardDAO();
        }
        public bool Add(Award award)
        {
            return _awardDAO.Add(award);
        }

        public bool Delete(int id)
        {
           return _awardDAO.Delete(id);
        }

        public List<Award> GetListAwards()
        {
            return _awardDAO.GetListAwards();
        }
        public void AddAwardForUser(int idUser, int idAward)
        {
            _awardDAO.AddAwardForUser(idAward, idUser);
        }

    }
}
