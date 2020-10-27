<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="예상문제03.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험2.예상문제03" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 78%;
        }
        .auto-style9 {
            width: 264px;
        }
        .auto-style10 {
            width: 139px;
        }
        .auto-style11 {
            color: #FF0000;
        }
    .auto-style12 {
        width: 139px;
        height: 26px;
    }
    .auto-style13 {
        width: 264px;
        height: 26px;
    }
    .auto-style14 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style8">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">회원정보</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">ID</td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" CssClass="auto-style11" ErrorMessage="ID 입력 누락">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">비밀 번호</td>
            <td class="auto-style9">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" CssClass="auto-style11" ErrorMessage="비밀 번호 누락">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">이름</td>
            <td class="auto-style9">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox6" CssClass="auto-style11" ErrorMessage="이름 누락">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">성별</td>
            <td class="auto-style9">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                    <asp:ListItem>남</asp:ListItem>
                    <asp:ListItem>여</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList1" CssClass="auto-style11" ErrorMessage="성별 누락">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">
                <asp:Button ID="Button1" runat="server" Text="확인" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Black" HeaderText="다음 표시된 부분을 수정하세요." ShowMessageBox="True" ShowSummary="False" Width="217px" />
    <p>
    </p>
</asp:Content>
