using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.Entities;

namespace Task3_Ado.DAL
{
    public interface IUserDAO
    {
        bool Delete(int id);
        bool Add(User user);
        List<string> GetListUsers();
    }
}
