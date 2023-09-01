using CRUD_Operation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CRUD_Operation.Data
{
    public class Repository
    {
        public List<User> GetAllUserData()
        {

            try
            {
                List<User> userlist = new List<User>();
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://localhost:7161/api/user/get-all").Result;

                if (response.IsSuccessStatusCode)
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseData);
                    foreach (var usr in users)
                    {
                        userlist.Add(new User
                        {
                            Id = usr.Id,
                            FirstName = usr.FirstName,
                            LastName = usr.LastName,
                            Address = usr.Address
                        });
                    }

                }

                return userlist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public User GetUserData(int id)
        {

            try
            {
                User user = new User();
                var httpClient = new HttpClient();
                var response = httpClient.GetAsync("https://localhost:7161/api/user/get-user/" + id).Result;

                if (response.IsSuccessStatusCode)
                {

                    var responseData = response.Content.ReadAsStringAsync().Result;
                    var users = JsonConvert.DeserializeObject<User>(responseData);
                    
                    user.Id = users.Id;
                    user.FirstName = users.FirstName;
                    user.LastName = users.LastName;

                    

                }

                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool InserUserData(User user)
        {
            try
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var httpClient = new HttpClient();
                var response = httpClient.PostAsync("https://localhost:7161/api/user/add-user", jsonContent);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateUserData(User user, int id)
        {
            try
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var httpClient = new HttpClient();
                var response = httpClient.PutAsync("https://localhost:7161/api/user/update-user/"+id, jsonContent);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteUserData(int id)
        {

            try
            {
                var httpClient = new HttpClient();
                var response = httpClient.DeleteAsync("https://localhost:7161/api/user/delete-user/" + id);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        
    }
}