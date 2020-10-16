<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="예상문제01.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험3.예상문제01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 257px;
            height: 326px;
            position: absolute;
            top: 202px;
            left: 262px;
            z-index: 1;
            text-align: center;
            background-color: #FF99CC;
        }
        .auto-style9 {
            width: 257px;
            height: 326px;
            position: absolute;
            top: 200px;
            left: 607px;
            z-index: 1;
            text-align: center;
            margin-top: 2px;
            background-color: #99CCFF;
        }
        .auto-style10 {
            width: 257px;
            height: 326px;
            position: absolute;
            top: 0px;
            left: 344px;
            z-index: 1;
            background-color: #99FFCC;
        }
        .auto-style11 {
            position: absolute;
            top: -65px;
            left: 33px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: -65px;
            left: 161px;
            z-index: 1;
        }
        .auto-style13 {
            width: 66%;
            height: 74px;
            position: absolute;
            top: 558px;
            left: 338px;
            z-index: 1;
            margin-top: 2px;
        }
        .auto-style14 {
            width: 509px;
        }
        .auto-style15 {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <div class="auto-style9">
        <div class="auto-style10">
            PRICE<br />
            <br />
            <asp:ListBox ID="ListBox3" runat="server" AutoPostBack="True" Height="269px" Width="215px"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style11" OnClick="Button1_Click" Text="주문 취소" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style12" OnClick="Button2_Click" Text="Clear" />
        ORDER<br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="268px" Width="220px"></asp:ListBox>
    </div>
    <div class="auto-style8">
        MENU<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="268px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="219px">
            <asp:ListItem Value="3000">짜장면</asp:ListItem>
            <asp:ListItem Value="19000">깐풍기</asp:ListItem>
            <asp:ListItem Value="4000">기스면</asp:ListItem>
            <asp:ListItem Value="6000">삼선우동</asp:ListItem>
            <asp:ListItem Value="50000">샥스핀</asp:ListItem>
            <asp:ListItem Value="5000">간짜장</asp:ListItem>
        </asp:ListBox>
    </div>
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
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <table class="auto-style13">
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style15"></asp:Label>
            </td>
            <td>중복주문 경고표시</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>주문수량 표시</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td>주문한 전체가격 표시</td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
