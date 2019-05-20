using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectionPollingManagement
{
    public partial class signUP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  protected void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\work\Documents\DCAP604DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into signUP_TB(username,userpassword,userEmail)values(@username,@userpassword,@userEmail)",con);
            cmd.Parameters.AddWithValue("username", txtName.Text);
            cmd.Parameters.AddWithValue("userpassword", txtPassword.Text);
            cmd.Parameters.AddWithValue("userEmail", txtEmail.Text);
            cmd.ExecuteNonQuery();
            Label1.Text = "Data Inserted Successfully";
            con.Close();
        }
    }
}