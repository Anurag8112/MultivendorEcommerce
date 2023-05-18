using MultivendorEcommerce.DAL.Dbmodels;
using MultivendorEcommerce.DAL.RequestModel;

namespace MultivendorEcommerce.Mapper
{
    public interface IUserMapper
    {
        public UserMaster MapUserSignupToUserMaster(UserSignup user);
    }
}
