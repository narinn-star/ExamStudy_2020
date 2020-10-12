<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제2번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험.실습문제2번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 275px;
        height: 330px;
        position: absolute;
        top: 142px;
        left: 898px;
        z-index: 1;
        text-align: center;
        background-color: #99CCFF;
    }
    .auto-style9 {
        width: 275px;
        height: 330px;
        position: absolute;
        top: 142px;
        left: 250px;
        background-color: #CCFF99;
    }
    .auto-style10 {
        width: 275px;
        height: 330px;
        position: absolute;
        top: 142px;
        left: 574px;
        z-index: 1;
        text-align: center;
        background-color: #FF99FF;
    }
    .auto-style11 {
        text-align: center;
    }
    .auto-style12 {
        text-align: justify;
    }
    .auto-style13 {
        position: absolute;
        top: 500px;
        left: 662px;
        z-index: 1;
        right: 500px;
    }
    .auto-style14 {
        position: absolute;
        top: 546px;
        left: 551px;
        z-index: 1;
    }
    .auto-style15 {
        position: absolute;
        top: 543px;
        left: 651px;
        z-index: 1;
        width: 223px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<div class="auto-style9" style="z-index: 1">
    <div class="auto-style11">
        <strong>과일 사세용~! (RBL)</strong><br />
    </div>
    <div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="275px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="263px">
            <asp:ListItem Value="5000">수박 (5000원)</asp:ListItem>
            <asp:ListItem Value="4000">파인애플 (4000원)</asp:ListItem>
            <asp:ListItem Value="4500">딸기 (4500원)</asp:ListItem>
            <asp:ListItem Value="3000">사과 (3000원)</asp:ListItem>
            <asp:ListItem Value="2500">오렌지 (2500원)</asp:ListItem>
            <asp:ListItem Value="2000">포도 (2000원)</asp:ListItem>
            <asp:ListItem Value="1000">귤 (1000원)</asp:ListItem>
        </asp:RadioButtonList>
    </div>
</div>
<div class="auto-style10">
    <strong>과일 더 사세용~! (CBL)<br />
    </strong>
    <div class="auto-style12">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Height="264px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="266px">
            <asp:ListItem Value="3000">배 (3000원)</asp:ListItem>
            <asp:ListItem Value="5000">바나나 (5000원)</asp:ListItem>
            <asp:ListItem Value="2000">감 (2000원)</asp:ListItem>
            <asp:ListItem Value="4500">메론 (4500원)</asp:ListItem>
            <asp:ListItem Value="1500">키위 (1500원)</asp:ListItem>
            <asp:ListItem Value="2500">망고 (2500원)</asp:ListItem>
            <asp:ListItem Value="1000">토마토 (1000원)</asp:ListItem>
        </asp:CheckBoxList>
    </div>
    <strong>
    <br />
    </strong>
    <div class="auto-style12">
    </div>
</div>
<div class="auto-style8">
    <strong>장바구니<br />
    <br />
    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="269px" Width="232px"></asp:ListBox>
    </strong>
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
    <asp:Label ID="Label1" runat="server" CssClass="auto-style14" Text="총 가격 : "></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style15"></asp:TextBox>
</p>
<p>
</p>
<p>
    <asp:Button ID="Button1" runat="server" CssClass="auto-style13" OnClick="Button1_Click" Text="초기화" />
</p>
</asp:Content>
