<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="예상문제02.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험2.예상문제02" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            font-size: large;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            color: #FF0000;
        }
        .auto-style11 {
            width: 208px;
        }
        .auto-style12 {
            width: 108px;
        }
        .auto-style13 {
            width: 381px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style8">
        <strong>Validation Summary Control</strong></p>
    <p>
        Credit Card 정보<table class="auto-style9">
            <tr>
                <td class="auto-style12">카드 형태 : </td>
                <td class="auto-style11">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                        <asp:ListItem>MasterCard</asp:ListItem>
                        <asp:ListItem>VisaCard</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" CssClass="auto-style10" EnableClientScript="False" ErrorMessage="카드 지정">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">카드 번호 : </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" CssClass="auto-style10" EnableClientScript="False" ErrorMessage="카드 번호">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">유효 기간 : </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" CssClass="auto-style10" EnableClientScript="False" ErrorMessage="Expire Date">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Button ID="Button1" runat="server" Text="확인" />
                </td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style10" Width="204px" />
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
