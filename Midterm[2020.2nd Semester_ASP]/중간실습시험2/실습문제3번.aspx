<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제3번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험2.실습문제3번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style8 {
            width: 64%;
            height: 134px;
            position: absolute;
            top: 74px;
            left: 344px;
            z-index: 1;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            width: 71%;
            height: 330px;
            position: absolute;
            top: 231px;
            left: 300px;
            z-index: 1;
        }
        .auto-style11 {
            width: 286px;
            height: 328px;
        }
        .auto-style12 {
            width: 315px;
            height: 328px;
        }
        .auto-style13 {
            position: absolute;
            top: 590px;
            left: 451px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 590px;
            left: 756px;
            z-index: 1;
        }
        .auto-style15 {
            height: 328px;
        }
        .auto-style16 {
            position: absolute;
            top: 357px;
            left: 547px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 588px;
            left: 546px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <table class="auto-style8">
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
    <table class="auto-style10">
        <tr>
            <td class="auto-style11">
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="297px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="277px">
                    <asp:ListItem>주문 메뉴입니다</asp:ListItem>
                    <asp:ListItem Value="3000">짜장면</asp:ListItem>
                    <asp:ListItem Value="25000">탕수육(대)</asp:ListItem>
                    <asp:ListItem Value="20000">탕수육(중)</asp:ListItem>
                    <asp:ListItem Value="15000">탕수육(소)</asp:ListItem>
                    <asp:ListItem Value="3500">짬뽕</asp:ListItem>
                    <asp:ListItem Value="30000">란자완스</asp:ListItem>
                </asp:ListBox>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style16">0</asp:TextBox>
            </td>
            <td class="auto-style12">
                <asp:Label ID="Label1" runat="server" Text="가격 : "></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server">1</asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="수량 : "></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server">1</asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="초기화" />
            </td>
            <td class="auto-style15">
                <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="297px" Width="277px">
                    <asp:ListItem>주문 사항입니다</asp:ListItem>
                </asp:ListBox>
            </td>
        </tr>
    </table>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style13" Text="총 수량 : "></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style14" Text="총 가격 : "></asp:Label>
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
        <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style17">0</asp:TextBox>
    </p>
</asp:Content>
