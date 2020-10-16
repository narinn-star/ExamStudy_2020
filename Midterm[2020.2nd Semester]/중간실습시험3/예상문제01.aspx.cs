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
            ListItem order = new ListItem(ListBox1.SelectedItem.Text, ListBox1.SelectedItem.Value);
            ListItem price = new ListItem(ListBox1.SelectedItem.Value, ListBox1.SelectedItem.Text);

            int del_item = ListBox2.Items.IndexOf(order);
            ListBox2.Items.Remove(order);
            ListBox2.Items.RemoveAt(del_item);
            Label1.Text = "";
            Label2.Text = "현재 요리 " + ListBox2.Items.Count.ToString() + "개를 주문하셨습니다.";

            int sum = 0;

            foreach(ListItem item in ListBox3.Items)
            {
                sum += int.Parse(item.Text.ToString());
            }
            Label3.Text = "주문한 전체 요리 가격은 " + sum + "입니다.";
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem order = new ListItem(ListBox1.SelectedItem.Text, ListBox1.SelectedItem.Value);
            ListItem price = new ListItem(ListBox1.SelectedItem.Value, ListBox1.SelectedItem.Text);

            if (ListBox2.Items.Contains(order))
                Label1.Text = "이미 주문하신 요리입니다.";

            else
            {
                ListBox2.Items.Add(order);
                ListBox3.Items.Add(price);
                Label1.Text = "";
                Label2.Text = "현재 요리 " + ListBox2.Items.Count.ToString() + "개를 주문하셨습니다.";
            }

            int sum = 0;

            foreach (ListItem item in ListBox3.Items)
                sum += int.Parse(item.Text.ToString());

            Label3.Text = "주문한 전체 요리 가격은 " + sum + " 입니다.";

            ListBox1.SelectedIndex = -1;
        }
    }
}