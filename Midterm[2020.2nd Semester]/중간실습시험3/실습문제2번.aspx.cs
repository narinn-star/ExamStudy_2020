using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Midterm_2020._2nd_Semester_.중간실습시험3
{
    public partial class 실습문제2번 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //계산
            ListBox1.Items.Clear();

           if(RadioButtonList1.SelectedIndex > -1)
            {
                ListBox1.Items.Add(new ListItem(RadioButtonList1.SelectedItem.Text,
                                                RadioButtonList1.SelectedItem.Value));
            }

           foreach(ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    ListBox1.Items.Add(new ListItem(item.Text, item.Value));
                }
            }
            int sum = 0;
            foreach(ListItem item in ListBox1.Items)
            {
                sum += int.Parse(item.Value);
            }
            TextBox1.Text = sum.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //초기화
            ListBox1.Items.Clear();
            TextBox1.Text = "";
            
            if(RadioButtonList1.SelectedIndex > -1)
            {
                RadioButtonList1.SelectedItem.Selected = false;
            }

            if(CheckBoxList1.SelectedIndex > -1)
            {
                foreach(ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                        item.Selected = false;
                }
            }
        }
    }
}