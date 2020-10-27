<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제1번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험.실습문제1번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 830px;
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
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table class="auto-style8">
        <tr>
            <td class="auto-style18" colspan="2">회원가입양식</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">로그인정보</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">사용자 ID : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">암호 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label13" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">암호 확인 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">개인정보 (선택사항)</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style25">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">이름 (한글) : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label15" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">이름 (영문) : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label16" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">상세주소 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label17" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">시/도 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label18" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">우편번호 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label19" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">전화번호 : </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:Label ID="Label11" runat="server"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:Label ID="Label20" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style25">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="비우기" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="확인" />
            </td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
        </tr>
    </table>
</p>
<p>
</p>
</asp:Content>
