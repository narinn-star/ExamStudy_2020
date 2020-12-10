<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Chap09_03.aspx.cs" Inherits="기말고사_대비.Fourth.Chap09_03" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="id" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                name:
                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                <br />
                department:
                <asp:Label ID="departmentLabel" runat="server" Text='<%# Eval("department") %>' />
                <br />
                grade:
                <asp:Label ID="gradeLabel" runat="server" Text='<%# Eval("grade") %>' />
                <br />
                sex:
                <asp:Label ID="sexLabel" runat="server" Text='<%# Eval("sex") %>' />
                <br />
                <hr />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VSexamConnectionString %>" SelectCommand="SELECT [id], [name], [department], [grade], [sex] FROM [StudentInfoTable01]"></asp:SqlDataSource>
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
