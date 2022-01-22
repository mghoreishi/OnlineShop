using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using AccountManagement.Domain.RoleAgg;
using System;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }
        public string Address { get;private set; }

        public Account(string fullname, string username, string password, string mobile,
            long roleId, string profilePhoto,string address)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            RoleId = roleId;

            if (roleId == 0)
                RoleId =Convert.ToInt64( Roles.Customer);
            
            ProfilePhoto = profilePhoto;
            Address = address;
        }

        public void Edit(string fullname, string username, string mobile,
            long roleId, string profilePhoto,string address)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
            RoleId = roleId;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;

            Address = address;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }
    }
}
