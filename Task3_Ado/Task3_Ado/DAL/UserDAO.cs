using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Ado.Entities;

namespace Task3_Ado.DAL
{
    class UserDAO : IUserDAO
    {
        private string _connection;
        public UserDAO()
        {
            _connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=Task3_Ado;Integrated Security=True";
        }
        public bool Add(User user)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connection);
                sqlConnection.Open();
                string insSqlString = "Insert into Users(Name, DateOfBirth, Age) Values('{0}', '{1}', {2})";
                insSqlString = string.Format(insSqlString, user.Name, user.DateOfBirth, user.Age);
                SqlCommand sqlCommand = new SqlCommand(insSqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connection);
                sqlConnection.Open();
                string delSqlString = "Delete from Users Where ID = {0}";
                delSqlString = string.Format(delSqlString, id);
                SqlCommand sqlCommand = new SqlCommand(delSqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetListUsers()
        {
            List<string> awards = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string selectSqlString = "Select Users.ID, Users.Name, Users.DateOfBirth, Users.Age, Awards.ID as AwardID, Awards.Title from Users " +
                    "Inner Join Users_Awards on users.ID = Users_Awards.UserID inner join Awards on Awards.ID = Users_Awards.AwardID";
                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    awards.Add(sqlDataReader["ID"].ToString() + " " + sqlDataReader["Name"].ToString() + " " + " " + 
                        sqlDataReader["Age"].ToString() + " " + sqlDataReader["AwardID"] + " " + sqlDataReader["Title"]);
                }
                return awards;
            }
        }
    } 
}