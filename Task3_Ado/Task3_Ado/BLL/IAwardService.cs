using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.Entities;

namespace Task3_Ado.BLL
{
    public interface IAwardService
    {

        bool Add(Award award);
        bool Delete(int ID);
        void AddAwardForUser(int idUser, int idAward);
        List<Award> GetListAwards();

    }
}
