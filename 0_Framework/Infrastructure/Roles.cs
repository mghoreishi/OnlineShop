namespace _0_Framework.Infrastructure
{
    public static class Roles
    {
        public const string Administrator = "2";
        public const string Customer = "4";
        public const string ContentUploader = "5";
        public const string ColleagueUser = "6";
        
        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 2:
                    return "Admin";
                case 5:
                    return "Normal User";
                default:
                    return "";
            }
        }
    }
}
