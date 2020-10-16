<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제1번(Validation).aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험2.실습문제1번_Validation_" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style8 {
        width: 977px;
        height: 348px;
    }
    .auto-style18 {
        text-align: center;
    }
    .auto-style25 {
        width: 207px;
    }
    .auto-style26 {
        width: 207px;
        text-align: right;
    }
        .auto-style29 {
            width: 148px;
            text-align: right;
        }
        .auto-style30 {
            width: 148px;
        }
        .auto-style31 {
            width: 328px;
        }
        .auto-style33 {
            color: #FF0000;
        }
        .auto-style34 {
            width: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;&nbsp;<table class="auto-style8">
        <tr>
            <td class="auto-style18" colspan="2">회원가입양식</td>
            <td class="auto-style30">&nbsp;</td>
            <td class="auto-style31">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">로그인정보</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style29">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">사용자 ID : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label12" runat="server"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="ID를 입력해주세요!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">암호 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label13" runat="server"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="암호를 입력해주세요!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">암호 확인 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label14" runat="server"></asp:Label>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox2" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="틀려써임마"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="입력해조"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">개인정보 (선택사항)</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style30">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">이름 (한글) : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label15" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">이름 (영문) : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label16" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">상세주소 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label17" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">시/도 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label18" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">우편번호 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label19" runat="server"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox8" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="올바르지 않은 우편번호" ValidationExpression="(D-)?\d{5}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">전화번호 : </td>
            <td class="auto-style34">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style29">
                <asp:Label ID="Label11" runat="server"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="Label20" runat="server"></asp:Label>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox9" CssClass="auto-style33" EnableClientScript="False" ErrorMessage="올바르지 않은 전화번호" ValidationExpression="01(0|1|6|7|8|9)-\d{3,4}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style34">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="비우기" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="확인" style="width: 50px" />
            </td>
            <td class="auto-style30">&nbsp;</td>
            <td class="auto-style31">&nbsp;</td>
        </tr>
    </table>
    </p>
    <p>
        <br />
    </p>
    </asp:Content>
