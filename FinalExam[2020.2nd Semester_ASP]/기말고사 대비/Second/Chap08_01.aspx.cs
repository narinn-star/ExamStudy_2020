using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace 기말고사_대비.Second
{
    public partial class 연습01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label1.Text = "";
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"server=(local)\SQLEXPRESS;Integrated Security=true;database=VSexam";
            SqlConnection Con = new SqlConnection(connectionstring);

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = TextBox1.Text;
            Con.Open();
            try
            {
                Cmd.ExecuteNonQuery();
                Con.Close();
                Label1.Text = "성공!";
                
            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
                Con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionstring = @"server=(local)\SQLEXPRESS;Integraded Security=true;database=VSexam";
            SqlConnection Con = new SqlConnection(connectionstring);

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = TextBox2.Text;
            Con.Open();
            try
            {
                Cmd.ExecuteNonQuery();
                Con.Close();
                Label2.Text = "성공!";
            }
            catch (Exception ee)
            {
                Label2.Text = ee.Message;
                Con.Close();
            } 
        }
    }
}