using API_QLHS.DTOs;
using API_QLHS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly MyDbContext _set;
        public UserController(MyDbContext Set)
        {
            _set = Set;
        }

        [HttpGet("GetUsers")]

        public async Task<IActionResult> GetUsers()
        {
            var result = _set.Users.ToList();
            return Ok(result);
        }


        [HttpGet("GetUserByCode")]
        public async Task<IActionResult> GetUserByCode(UserRequestDTO req)
        {
            //linq
            List<User> result = _set.Users.Where(u => u.Code == req.Code).ToList<User>();

            List<UserResponseDTO> res = new List<UserResponseDTO>();
            foreach (User u in result)
            {
                var uRes = new UserResponseDTO(u.Code, u.Name, u.Phone, u.Email);
                res.Add(uRes);
            }

            return Ok(res);
        }

        [HttpPost("GetUserByManager")]
        public async Task<IActionResult> GetUserByManage(UserManageRequestDTO req)
        {
            //linq
            List<User> result = _set.Users.Where(u => u.ManagerCode == req.ManagerCode).ToList<User>();

            List<ManagerResponseDTO> res = new List<ManagerResponseDTO>();
            foreach (User u in result)
            {
                var uRes = new ManagerResponseDTO(u.Code, u.Name, u.Phone, u.Email, u.ManagerCode);
                res.Add(uRes);
            }

            return Ok(res);
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(UserCreateRequestDTO req)
        {
            //linq
            var user = new User()
            {
                Code = req.Code,
                CpnyCode = req.CpnyCode,
                SiteCode = req.SiteCode,
                Name = req.Name,
                Phone = req.Phone,
                Email = req.Email,
                Password = req.Password,
                ManagerCode = req.ManagerCode,
                CategoryCode = req.CategoryCode,
                GroupCode = req.GroupCode,
                RegistationDate = req.RegistationDate ,
                ExpireDay = req.ExpireDay,
                Status = req.Status,
                RecentLogin = req.RecentLogin,
                StartDate = req.StartDate,
                EndDate = req.EndDate  

            };

            _set.Users.Add(user);
            _set.SaveChanges();

            return Ok(_set.Users.Where(u => u.Code == req.Code));
        }
    }
}
