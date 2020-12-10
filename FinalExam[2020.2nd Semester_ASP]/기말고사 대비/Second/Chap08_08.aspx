<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Chap08_08.aspx.cs" Inherits="기말고사_대비.Second.Chap08_08" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        성별 선택 -&gt;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="50px">
            <asp:ListItem>F</asp:ListItem>
            <asp:ListItem>M</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="66px">
            <asp:ListItem>AND</asp:ListItem>
            <asp:ListItem Value="OR">OR</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Height="18px" Width="48px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
        </asp:DropDownList>
&nbsp;&lt;- grade 선택</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="위의 조건으로 검색" Width="167px" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p class="auto-style4">
        <asp:Table ID="Table1" runat="server" GridLines="Both" Width="537px">
        </asp:Table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
