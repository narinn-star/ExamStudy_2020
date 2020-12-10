<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="1번.aspx.cs" Inherits="기말고사_대비.Third._1번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        성별과 Grade 필드의 복수의 조건을 만족하는 데이터 검색(SELECT) 예제!</p>
    <p>
        &nbsp;성별 선택 -&gt; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>F</asp:ListItem>
            <asp:ListItem>M</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="AND">AND</asp:ListItem>
            <asp:ListItem Value="OR">OR</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Value="1">1학년</asp:ListItem>
            <asp:ListItem Value="2">2학년</asp:ListItem>
            <asp:ListItem Value="3">3학년</asp:ListItem>
            <asp:ListItem Value="4">4학년</asp:ListItem>
        </asp:DropDownList>
&nbsp;&lt;- Grade 선택</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="위의 조건으로 검색" Width="274px" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Table ID="Table1" runat="server" GridLines="Both">
        </asp:Table>
    </p>
    <p>
    </p>
</asp:Content>
