using System.Collections.Generic;

namespace DbCommon
{
    // This really should be in a separate assembly from Repository.

    public interface IRepository
    {
        void AddUser(string firstName, string lastName);
        List<UserModel> ReadUsers();
        List<TUser> ReadUsersAs<TUser>(string filter = null) where TUser : UserModel;
    }
}