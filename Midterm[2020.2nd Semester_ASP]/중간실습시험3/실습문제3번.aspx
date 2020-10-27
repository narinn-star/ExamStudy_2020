<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제3번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험3.실습문제3번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 74%;
            height: 340px;
            position: absolute;
            top: 194px;
            left: 288px;
            z-index: 1;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            width: 89%;
            height: 110px;
            position: absolute;
            top: -124px;
            left: 62px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <table class="auto-style8">
            <tr>
                <td class="auto-style9">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="260px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="248px">
                        <asp:ListItem>주문 메뉴입니당</asp:ListItem>
                        <asp:ListItem Value="3000">짜장면</asp:ListItem>
                        <asp:ListItem Value="25000">탕수육(대)</asp:ListItem>
                        <asp:ListItem Value="20000">탕수육(중)</asp:ListItem>
                        <asp:ListItem Value="15000">탕수육(소)</asp:ListItem>
                        <asp:ListItem Value="3500">짬뽕</asp:ListItem>
                        <asp:ListItem Value="30000">란자완스</asp:ListItem>
                    </asp:ListBox>
        <table class="auto-style10">
            <tr>
                <td class="auto-style9" colspan="4"><strong>주문 Menu 설정값</strong></td>
            </tr>
            <tr>
                <td class="auto-style9">짜장면</td>
                <td class="auto-style9">3000</td>
                <td class="auto-style9">탕수육(소)</td>
                <td class="auto-style9">15000</td>
            </tr>
            <tr>
                <td class="auto-style9">탕수육(대)</td>
                <td class="auto-style9">25000</td>
                <td class="auto-style9">짬뽕</td>
                <td class="auto-style9">3500</td>
            </tr>
            <tr>
                <td class="auto-style9">탕수육(중)</td>
                <td class="auto-style9">20000&nbsp;</td>
                <td class="auto-style9">란자완스</td>
                <td class="auto-style9">30000</td>
            </tr>
        </table>
                </td>
                <td class="auto-style9">가격 :
                    <asp:TextBox ID="TextBox1" runat="server">1</asp:TextBox>
                    <br />
                    <br />
                    수량 :
                    <asp:TextBox ID="TextBox2" runat="server">1</asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="초기화" />
                    <br />
                    <br />
                    총 가격 :
                    <asp:TextBox ID="TextBox3" runat="server">0</asp:TextBox>
                    <br />
                    <br />
                    총 수량 :
                    <asp:TextBox ID="TextBox4" runat="server">0</asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="260px" Width="248px">
                        <asp:ListItem>주문 사항입니당</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
