using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.Entities;

namespace Task3_Ado.BLL
{
    public interface IUserService
    {
        bool Add(User user);
        bool Delete(int ID);

        List<string> GetListUsersAndAwards();
    }
}
