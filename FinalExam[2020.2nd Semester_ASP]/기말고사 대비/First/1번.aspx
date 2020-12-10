<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="1번.aspx.cs" Inherits="기말고사_대비.First._1번" %>
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
&nbsp; 성별 선택 :
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem Value="M">M(남자)</asp:ListItem>
            <asp:ListItem Value="F">F(여자)</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            <asp:ListItem>AND</asp:ListItem>
            <asp:ListItem>OR</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1">1학년</asp:ListItem>
            <asp:ListItem Value="2">2학년</asp:ListItem>
            <asp:ListItem Value="3">3학년</asp:ListItem>
            <asp:ListItem Value="4">4학년</asp:ListItem>
        </asp:DropDownList>
&nbsp;: Grade 선택</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="위 조건으로 검색" Width="263px" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <div class="auto-style4">
        <asp:Table ID="Table1" runat="server" GridLines="Both" Height="68px" Width="611px">
        </asp:Table>
    </div>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
