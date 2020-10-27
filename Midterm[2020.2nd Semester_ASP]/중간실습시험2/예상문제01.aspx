<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="예상문제01.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험2.예상문제" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>예상문제 _ Table 자동으로 만들기</strong></p>
    <p>
        &nbsp;</p>
    <p>
        <strong>
        <asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines="Both">
        </asp:Table>
        </strong>
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
        Table Rows :
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="표 작성" />
    </p>
    <p>
        Table Cells :
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
</asp:Content>
