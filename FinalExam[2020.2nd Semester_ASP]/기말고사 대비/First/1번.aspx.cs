using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace 기말고사_대비.First
{
    public partial class _1번 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"server=(local)\SQLEXPRESS;Integrated Security=true;database=VSexam";
            SqlConnection Con = new SqlConnection(connectionstring);

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "select * from StudentInfoTable01 where sex='" + DropDownList1.SelectedValue + "' " 
                + DropDownList2.SelectedValue + " grade="+ DropDownList3.SelectedValue;
           
            Con.Open();
            SqlDataReader reader = Cmd.ExecuteReader();

            try
            {
                TableRow r1 = new TableRow();
                TableCell c11 = new TableCell();
                c11.Controls.Add(new LiteralControl("id"));
                r1.Cells.Add(c11);
                TableCell c22 = new TableCell();
                c22.Controls.Add(new LiteralControl("name"));
                r1.Cells.Add(c22);
                TableCell c33 = new TableCell();
                c33.Controls.Add(new LiteralControl("department"));
                r1.Cells.Add(c33);
                TableCell c44 = new TableCell();
                c44.Controls.Add(new LiteralControl("grade"));
                r1.Cells.Add(c44);
                TableCell c55 = new TableCell();
                c55.Controls.Add(new LiteralControl("email"));
                r1.Cells.Add(c55);
                TableCell c66 = new TableCell();
                c66.Controls.Add(new LiteralControl("sex"));
                r1.Cells.Add(c66);
                Table1.Rows.Add(r1);

                while (reader.Read())
                {
                    TableRow r = new TableRow();
                    TableCell c1 = new TableCell();
                    c1.Controls.Add(new LiteralControl(reader["id"].ToString()));
                    r.Cells.Add(c1);
                    TableCell c2 = new TableCell();
                    c2.Controls.Add(new LiteralControl(reader["name"].ToString()));
                    r.Cells.Add(c2);
                    TableCell c3 = new TableCell();
                    c3.Controls.Add(new LiteralControl(reader["department"].ToString()));
                    r.Cells.Add(c3);
                    TableCell c4 = new TableCell();
                    c4.Controls.Add(new LiteralControl(reader["grade"].ToString()));
                    r.Cells.Add(c4);
                    TableCell c5 = new TableCell();
                    c5.Controls.Add(new LiteralControl(reader["email"].ToString()));
                    r.Cells.Add(c5);
                    TableCell c6 = new TableCell();
                    c6.Controls.Add(new LiteralControl(reader["sex"].ToString()));
                    r.Cells.Add(c6);
                    Table1.Rows.Add(r);
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
            }
            Con.Close();
        }
    }
}