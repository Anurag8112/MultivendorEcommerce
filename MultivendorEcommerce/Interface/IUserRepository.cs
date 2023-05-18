using MultivendorEcommerce.DAL.RequestModel;

namespace MultivendorEcommerce.Interface
{
    public interface IUserRepository
    {
        public string UserSignUp(UserSignup user);
        public string UserLogin(UserLogin user);
        public string ForgetPassword(FogetPassword Request);
        public string UserLogout(string token);
    }
}
