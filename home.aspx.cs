﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeManagementSystem
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            String userpassword = TextBox2.Text;
            if(username.Equals("admin") && userpassword.Equals("admin123"))
            {
                Response.Redirect("welcome.aspx");
            }
            else
            {
                Label3.Text = "Invalid user";
            }
        }
    }
}