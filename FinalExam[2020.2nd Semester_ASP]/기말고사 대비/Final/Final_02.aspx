<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Final_02.aspx.cs" Inherits="기말고사_대비.Final.Final_02" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        text-align: justify;
    }
    .auto-style5 {
        color: #FF0000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    ID
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style5" ErrorMessage="ID 입력"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style5" ValidationExpression="[a-zA-Z0-9]{2,10}">영문, 숫자 2-10자</asp:RegularExpressionValidator>
</p>
<p>
    성별
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style5" ErrorMessage="성별 입력"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style5" ErrorMessage="M|F" ValidationExpression="M|F"></asp:RegularExpressionValidator>
</p>
<p class="auto-style4">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="95px" />
&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<asp:Table ID="Table1" runat="server" GridLines="Both" Width="570px">
</asp:Table>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
