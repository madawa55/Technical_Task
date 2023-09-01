using Backend_with_DB.Models;

namespace Backend_with_DB.Repository
{
    public class Repository:IRepository
    {
        private UserManagmentDatabaseContext db;
        public List<User> GetAllData()
        {
            try
            {
                List<User> data = new List<User>();
                using (db = new UserManagmentDatabaseContext())
                {
                    data = (from x in db.Users select x).ToList();
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetDataByUser(int id)
        {
            try
            {
                User userdata = new User();
                using (db = new UserManagmentDatabaseContext())
                {
                    userdata = (from x in db.Users where x.Id == id select x).FirstOrDefault();
                    return userdata;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertUserData(User userdata)
        {
            try
            {
                using (db = new UserManagmentDatabaseContext())
                {
                    User user = new User();
                    user.FirstName = userdata.FirstName;
                    user.LastName = userdata.LastName;
                    user.Address = userdata.Address;
                    user.CreatedOn = DateTime.Now;
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateUserData(User userdata, int id)
        {
            try
            {
                using (db = new UserManagmentDatabaseContext())
                {
                    User user = (from x in db.Users where x.Id == id select x).FirstOrDefault();
                    user.FirstName = userdata.FirstName;
                    user.LastName = userdata.LastName;
                    user.Address = userdata.Address;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUserData(int id)
        {
            try
            {
                using (db = new UserManagmentDatabaseContext())
                {
                    User user = (from x in db.Users where x.Id == id select x).FirstOrDefault();
                    db.Remove(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
