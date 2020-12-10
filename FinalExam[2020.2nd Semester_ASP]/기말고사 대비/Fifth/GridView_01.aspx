<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GridView_01.aspx.cs" Inherits="기말고사_대비.Fifth.GridView_01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="765px">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="department" HeaderText="department" SortExpression="department" />
            <asp:BoundField DataField="grade" HeaderText="grade" SortExpression="grade" />
            <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
            <asp:HyperLinkField DataNavigateUrlFormatString="DetailsView_01.aspx?field={0}" HeaderText="DetailsView" NavigateUrl="~/Fifth/DetailsView_01.aspx" Text="Details" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VSexamConnectionString %>" SelectCommand="SELECT [id], [department], [grade], [sex] FROM [StudentInfoTable01]"></asp:SqlDataSource>
</p>
<p>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource2" Height="50px" Width="271px">
        <Fields>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="department" HeaderText="department" SortExpression="department" />
            <asp:BoundField DataField="grade" HeaderText="grade" SortExpression="grade" />
            <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
        </Fields>
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:VSexamConnectionString %>" SelectCommand="SELECT DISTINCT [id], [department], [sex], [grade] FROM [StudentInfoTable01] WHERE ([id] = @id)">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
<p>
</p>
</asp:Content>
