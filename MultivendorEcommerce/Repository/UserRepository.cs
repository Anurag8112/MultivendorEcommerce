using Microsoft.Extensions.Logging;
using MultivendorEcommerce.DAL.Dbmodels;
using MultivendorEcommerce.DAL.RequestModel;
using MultivendorEcommerce.Interface;
using MultivendorEcommerce.Mapper;
using MultivendorEcommerce.Shared;
using Newtonsoft.Json;
using System;

namespace MultivendorEcommerce.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ILoggerManager logger;
        private readonly IUserMapper userMapper;
        public UserRepository(ILoggerManager logger, IUserMapper userMapper)
        {
            this.logger = logger;
            this.userMapper = userMapper;
        }
        public string UserSignUp(UserSignup user)
        {
            try
            {
                HomealignContext homealignContext = new HomealignContext();
                var User = userMapper.MapUserSignupToUserMaster(user);
                Helpers.GenerateOTP(User.PhoneNumber, User.Id);
                homealignContext.UserMasters.Add(User);
                var Result=homealignContext.SaveChanges();
                return "User SignUp Complete";
            }
            catch(Exception ex)
            {
                logger.Error(JsonConvert.SerializeObject(ex));
                throw;
            }
        }

        public string UserLogin(UserLogin user)
        {
            try
            {
                return "User Login Complete";
            }
            catch (Exception ex)
            {
                logger.Error(JsonConvert.SerializeObject(ex));
                throw;
            }
        }

        public string UserLogout(string token)
        {
            try
            {
                return "User Logout Complete";
            }
            catch (Exception ex)
            {
                logger.Error(JsonConvert.SerializeObject(ex));
                throw;
            }
        }
        public string ForgetPassword(FogetPassword Request)
        {
            try
            {
                return "Password Forget Complete";
            }
            catch (Exception ex)
            {
                logger.Error(JsonConvert.SerializeObject(ex));
                throw;
            }
        }
    }
}
