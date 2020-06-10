using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.DAL;
using Task3_Ado.Entities;

namespace Task3_Ado.BLL
{
    class UserService: IUserService
    {
        private UserDAO _userDAO;
        public UserService()
        {
            _userDAO = new UserDAO();
        }

        public bool Add(User user)
        {
            return _userDAO.Add(user);
        }

        public bool Delete(int id)
        {
           return _userDAO.Delete(id);
        }
        public List<string> GetListUsersAndAwards()
        {
            return _userDAO.GetListUsers();
        }
    }
}
