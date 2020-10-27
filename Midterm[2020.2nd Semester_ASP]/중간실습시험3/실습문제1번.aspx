<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제1번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험3.실습문제1번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 979px;
        }
        .auto-style10 {
            height: 24px;
            text-align: center;
        }
        .auto-style15 {
            height: 24px;
            width: 208px;
        }
        .auto-style17 {
            width: 208px;
        }
        .auto-style19 {
            height: 24px;
            width: 122px;
        }
        .auto-style20 {
            width: 122px;
        }
        .auto-style21 {
            width: 172px;
        }
        .auto-style22 {
            width: 185px;
        }
        .auto-style23 {
            color: #FF0000;
        }
        .auto-style24 {
            width: 172px;
            text-align: right;
        }
        .auto-style25 {
            width: 122px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <table class="auto-style8">
            <tr>
                <td class="auto-style10" colspan="2">회원가입양식</td>
                <td class="auto-style19"></td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style21">로그인 정보</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style20">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">사용자 ID</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">암호</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">암호확인</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox2" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="CompareValidator"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">개인정보(선택사항)</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style20">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">이름(한글)</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">이름(영문)</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">상세주소</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label17" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">시/도</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label18" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">우편번호</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label19" runat="server"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox8" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">전화번호</td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style25">
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
                <td class="auto-style17">
                    <asp:Label ID="Label20" runat="server"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox9" CssClass="auto-style23" EnableClientScript="False" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style22">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="초기화" />
&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="확인" />
                </td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
        </table>
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
    </p>
    <p>
    </p>
</asp:Content>
