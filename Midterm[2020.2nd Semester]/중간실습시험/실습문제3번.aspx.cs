using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Midterm_2020._2nd_Semester_.중간실습시험
{
    public partial class 실습문제3번 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "1";
            TextBox3.Text = "0";
            TextBox4.Text = "0";
            ListBox2.Items.Clear();
            ListBox2.Items.Add("주문 사항입니다.");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex > 0)
            {
                TextBox1.Text = ListBox1.SelectedItem.Value;
                bool samemenu = false; int itemindex = 0; int itemValue = 0; string itemText = "";
                foreach(ListItem item in ListBox2.Items)
                {
                    if (item.Text.Contains(ListBox1.SelectedItem.Text))
                    {
                        samemenu = true;
                        itemValue = int.Parse(item.Value);
                        itemText = item.Text;
                        itemindex = ListBox2.Items.IndexOf(new ListItem(item.Text, item.Value));
                    }
                }

                if (!samemenu) //첫 주문
                {
                    string firstorder = ListBox1.SelectedItem.Text + "[" + TextBox2.Text + "]그릇";
                    ListBox2.Items.Add(new ListItem(firstorder, ListBox1.SelectedItem.Value.ToString()));
                }
                else //추가 주문
                {
                    string zeroindex = itemText.Substring(itemText.IndexOf("[") + 1);
                    int neworder = int.Parse(zeroindex.Substring(0, zeroindex.IndexOf("]"))) + int.Parse(TextBox2.Text);
                    string newordertext = ListBox1.SelectedItem.Text + "[" + neworder + "]그릇";

                    ListBox2.Items.Remove(new ListItem(itemText, itemValue.ToString()));
                    ListBox2.Items.Insert(itemindex, new ListItem(newordertext, ListBox1.SelectedItem.Value));
                }
                ListBox1.SelectedIndex = -1;

                //계산
                int TotalOrder = 0;
                int TotalPrice = 0;
                int EachOrder = 0;

                foreach(ListItem item in ListBox2.Items)
                {
                    if (item.Text.Contains("["))
                    {
                        TotalOrder += int.Parse(item.Text.Substring(item.Text.IndexOf("[") + 1,
                                         (item.Text.IndexOf("]") - item.Text.IndexOf("[") - 1)));
                    }
                }

                foreach(ListItem item in ListBox2.Items)
                {
                    if (item.Text.Contains("]"))
                    {
                        EachOrder = int.Parse(item.Text.Substring(item.Text.IndexOf("[") + 1,
                                        (item.Text.IndexOf("]") - item.Text.IndexOf("[") - 1)));
                        TotalPrice += EachOrder * int.Parse(item.Value);
                    }
                }
                TextBox3.Text = TotalOrder.ToString();
                TextBox4.Text = TotalPrice.ToString();
            }
        }
    }
}