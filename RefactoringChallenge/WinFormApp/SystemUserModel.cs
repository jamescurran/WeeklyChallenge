namespace WinFormApp
{
    public class SystemUserModel : DbCommon.UserModel
    {
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
