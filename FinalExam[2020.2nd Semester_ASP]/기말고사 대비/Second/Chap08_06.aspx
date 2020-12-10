<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Chap08_06.aspx.cs" Inherits="기말고사_대비.Second.Chap08_06" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        By Grade Order :
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>정렬 안함</asp:ListItem>
            <asp:ListItem Value="ASC">Ascending Order(오름차순)</asp:ListItem>
            <asp:ListItem Value="DESC">Descending Order(내림차순)</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Table 정렬하기" Width="146px" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p class="auto-style4">
        <asp:Table ID="Table1" runat="server" GridLines="Both" Height="27px" Width="659px">
        </asp:Table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
