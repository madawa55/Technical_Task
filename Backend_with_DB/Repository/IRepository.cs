using Backend_with_DB.Models;

namespace Backend_with_DB.Repository
{
    public interface IRepository
    {
        public List<User> GetAllData();
        public User GetDataByUser(int id);
        public bool InsertUserData(User userdata);
        public bool UpdateUserData(User userdata, int id);
        public bool DeleteUserData(int id);
    }
}
