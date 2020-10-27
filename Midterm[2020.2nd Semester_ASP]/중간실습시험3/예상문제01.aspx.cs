using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Midterm_2020._2nd_Semester_.중간실습시험3
{
    public partial class 예상문제01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();
            ListBox3.Items.Clear();
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox2.Items.Count > 0)
            {
                string menu, price;
                menu = ListBox2.SelectedItem.Text.ToString();
                price = ListBox2.SelectedItem.Value.ToString();

                ListItem text = new ListItem(menu, price);
                ListItem value = new ListItem(price, menu);

                int index_sel = ListBox2.Items.IndexOf(text);
                ListBox2.Items.Remove(text);
                ListBox3.Items.RemoveAt(index_sel);
                Label1.Text = "";
                Label2.Text = "현재 요리 " + ListBox2.Items.Count.ToString() + "개 주문하셨슴다";
                int sum = 0;
                foreach (ListItem item in ListBox3.Items)
                {
                    sum += int.Parse(item.Text);
                }
                Label3.Text = "총 가격은 " + sum.ToString() + "임다";
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string menu, price;
            menu = ListBox1.SelectedItem.Text.ToString();
            price = ListBox1.SelectedItem.Value.ToString();

            ListItem text = new ListItem(menu, price);
            ListItem value = new ListItem(price, menu);

            if (ListBox2.Items.Contains(text))
            {
                Label1.Text = "이미 주문하셨슴다";
            }
            else
            {
                ListBox2.Items.Add(text);
                ListBox3.Items.Add(value);
                Label1.Text = "";
            }
            Label2.Text = "현재 요리 " + ListBox2.Items.Count.ToString() + "개를 주문하셨슴다";

            int sum = 0;
            foreach(ListItem item in ListBox3.Items)
            {
                sum += int.Parse(item.Text.ToString());
            }
            Label3.Text = "총 가격은 " + sum.ToString() + " 임다";

            ListBox1.SelectedIndex = -1;
        }
    }
}