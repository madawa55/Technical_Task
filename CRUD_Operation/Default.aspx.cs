using CRUD_Operation.Data;
using CRUD_Operation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CRUD_Operation
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
            }

        }

        public void display()
        {
            Repository repo = new Repository();
            List<User> data = repo.GetAllUserData();
            DataTable dt = new DataTable();           
            dt = ToDataTable<User>(data);
            GridView1.DataSource = dt;
            GridView1.DataBind();
           
        }

        protected void lnkselect_Click(object sender, EventArgs e)
        {
            Repository repo = new Repository();
            LinkButton btn = (LinkButton)sender;
            Session["Id"] = btn.CommandArgument;
            string id = btn.CommandArgument;
            txtid.Value = btn.CommandArgument;
            User user = repo.GetUserData(Convert.ToInt32(id));
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtAddress.Text = user.Address;

        }

        protected void lnkview_Click(object sender, EventArgs e)
        {
           
            LinkButton btn = (LinkButton)sender;           
            string id = btn.CommandArgument;
            Response.Redirect(string.Format("~/ViewPage.aspx?id={0}", id));


        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.Address = txtAddress.Text;
            Repository repo = new Repository();
            bool response = repo.InserUserData(usr);
            if(!response)
            {
                lblmsg.Text = "Something Went Wrong, Please check details Again";
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            User usr = new User();
            usr.FirstName = txtFirstName.Text;
            usr.LastName = txtLastName.Text;
            usr.Address = txtAddress.Text;
            int id = Convert.ToInt32(txtid.Value);
            Repository repo = new Repository();
            bool response = repo.UpdateUserData(usr,id);
            if (!response)
            {
                lblmsg.Text = "Something Went Wrong, Please check details Again";
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Value);
            Repository repo = new Repository();
            bool response = repo.DeleteUserData(id);
            if (!response)
            {
                lblmsg.Text = "Something Went Wrong, Please check details Again";
            }
        }

        
        public static DataTable ToDataTable<T>(List<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}