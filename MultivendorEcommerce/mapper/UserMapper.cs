using MultivendorEcommerce.DAL.Dbmodels;
using MultivendorEcommerce.DAL.RequestModel;
using MultivendorEcommerce.Encript_Decrypt;

namespace MultivendorEcommerce.Mapper
{
    public class UserMapper : IUserMapper
    {
        public UserMaster MapUserSignupToUserMaster(UserSignup user)
        {
            UserMaster userMaster = new();
            userMaster.UserName = user.UserName;
            userMaster.Password = Password.HashEncrypt(user.Password);
            userMaster.Email = user.Email;
            userMaster.PhoneNumber = user.PhoneNumber;
            userMaster.FirstName = user.FirstName;
            userMaster.LastName = user.LastName;
            userMaster.GenderId = user.GenderId;
            userMaster.IsPolicyAccepted = user.IsPolicyAccepted;
            userMaster.IsVerified = false;
            userMaster.IsActive = true;
            return userMaster;
        }
    }
}
