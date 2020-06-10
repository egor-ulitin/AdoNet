using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.Entities;

namespace Task3_Ado.DAL
{

    public interface IAwardDAO
    {
        bool Delete(int id);
        bool Add(Award award);
        bool AddAwardForUser(int idAward, int idUser);
        List<Award> GetListAwards();

    }
}
