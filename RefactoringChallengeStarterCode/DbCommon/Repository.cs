using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;


namespace DbCommon
{
    public class Repository
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

        public  List<TUser> ReadUsersAs<TUser>()
        where TUser: UserModel
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                return cnn.Query<TUser>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<UserModel> ReadUsers() => ReadUsersAs<UserModel>();


        public List<TUser> ReadFilteredUsersAs<TUser>(string filter)
            where TUser : UserModel
        {
            using (IDbConnection cnn = new SqlConnection(_connectionString))
            {
                var p = new
                {
                    Filter = filter
                };

                return  cnn.Query<TUser>("spSystemUser_GetFiltered", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
