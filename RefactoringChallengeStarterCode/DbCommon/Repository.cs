using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;


namespace DbCommon
{
    public class Repository : IRepository
    {
        private readonly string _connectionString;
        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddUser(string firstName, string lastName)
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                var p = new
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                cnn.Execute("dbo.spSystemUser_Create", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<UserModel> ReadUsers() => ReadUsersAs<UserModel>();


        public List<TUser> ReadUsersAs<TUser>(string filter=null)
            where TUser : UserModel
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                object parameter = null;
                string proc = "spSystemUser_Get";
                if (filter != null)
                {
                    parameter = new
                    {
                        Filter = filter
                    };
                    proc = "spSystemUser_GetFiltered";
                }
                return  cnn.Query<TUser>(proc, parameter, commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
