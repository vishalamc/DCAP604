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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label1.Text = "Hello";

            }
            else
            {
                Label1.Text = "Bye";
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\work\Documents\DCAP604DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from signUP_TB where userEmail=@userEmail and userpassword=@userpassword",con);
            cmd.Parameters.AddWithValue("userEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("userpassword", txtPassword.Text);

            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(ds);
            con.Close();
            if(ds.Tables[0].Rows.Count>0)
            {
                Session["user"] = txtEmail.Text;
                Response.Redirect("profile.aspx");
            }
            else
            {
                Label1.Text = "Invalid User";
                //Response.Redirect("error.aspx");
            }
                

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}