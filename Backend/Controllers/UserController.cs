using Backend.Models;
using Backend.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{   
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IRepository _repository;
        public UserController(IRepository repository)
        {
            _repository = repository;
        }
        [Route("api/user/get-all")]
        [HttpGet]
        public List<User> GetAll()
        {
            List<User> users = _repository.GetAllData();
            return users;
        }

        [Route("api/user/get-user/{id}")]
        [HttpGet]
        public User GetDataByUser(int id)
        {
            User user = _repository.GetDataByUser(id);
            return user;
        }

        [Route("api/user/add-user")]
        [HttpPost]
        public bool Post([FromBody] User value)
        {
            bool result = _repository.InsertUserData(value);
            return result;
        }

        [Route("api/user/update-user/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] User value)
        {
            bool result = _repository.UpdateUserData(value, id);
            return result;
        }

        [Route("api/user/delete-user/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            bool result = _repository.DeleteUserData(id);
            return result;
        }
    }
}
