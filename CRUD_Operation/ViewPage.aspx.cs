using CRUD_Operation.Data;
using CRUD_Operation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Operation
{
    public partial class ViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string id = Request.QueryString["id"];
                display(Convert.ToInt32(id));


            }
        }

        public void display(int id)
        {
            Repository repo = new Repository();
            User data = repo.GetUserData(id);          
            txtAddress.Text = data.Address;
            txtFirstName.Text = data.FirstName;
            txtLastName.Text = data.LastName;

        }
    }
}