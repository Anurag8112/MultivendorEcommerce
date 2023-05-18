using Microsoft.AspNetCore.Mvc;
using MultivendorEcommerce.DAL.RequestModel;
using MultivendorEcommerce.Interface;
using Newtonsoft.Json.Linq;
using System;

namespace MultivendorEcommerce.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("api/v1/User/SignUp")]
        public IActionResult SignUp(UserSignup user)
        {
            try
            {
                var Result = _userRepository.UserSignUp(user);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v1/User/Login")]
        public IActionResult Login(UserLogin user)
        {
            try
            {
                var Result = _userRepository.UserLogin(user);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v1/User/ForgetPassword")]
        public IActionResult ForgetPassword(FogetPassword Request)
        {
            try
            {
                var Result = _userRepository.ForgetPassword(Request);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v1/User/LogOut")]
        public IActionResult LogOut()
        {
            try
            {
                var header = Request.Headers;
                if (header.ContainsKey("token"))
                {
                    var token = header["token"];
                    var Result = _userRepository.UserLogout(token);
                    return Ok(Result);
                }
                else
                {
                    throw new Exception("Invalid Header");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
