using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace 기말고사_대비.Second
{
    public partial class Chap08_03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            string name = TextBox2.Text;
            string department = TextBox3.Text;
            string grade = TextBox4.Text;
            string email = TextBox5.Text;
            string sex = TextBox6.Text;

            string connectionstring = @"server=(local)\SQLEXPRESS;Integrated Security=true;database=VSexam";
            SqlConnection Con = new SqlConnection(connectionstring);

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Insert into StudentInfoTable01 (id, name, department, grade, email, sex)" +
                            "values ('" + id + "', '" + name + "', '" + department + "', " + grade + ", '" + email 
                                        + "', '" + sex + "')";

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
    }
}