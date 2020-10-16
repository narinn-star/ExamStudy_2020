<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="실습문제2번.aspx.cs" Inherits="Midterm_2020._2nd_Semester_.중간실습시험3.실습문제2번" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 284px;
            height: 304px;
            position: absolute;
            top: 226px;
            left: 282px;
            z-index: 1;
            background-color: #FFCCCC;
        }
        .auto-style9 {
            width: 284px;
            height: 304px;
            position: absolute;
            top: 226px;
            left: 597px;
            z-index: 1;
            text-align: center;
            background-color: #FFCC99;
        }
        .auto-style10 {
            width: 284px;
            height: 304px;
            position: absolute;
            top: 225px;
            left: 913px;
            z-index: 1;
            text-align: center;
            background-color: #FFFFCC;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            text-align: justify;
        }
        .auto-style13 {
            position: absolute;
            top: 549px;
            left: 624px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 549px;
            left: 752px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 588px;
            left: 607px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 587px;
            left: 713px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <div class="auto-style10">
        ListBox<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="257px" Width="269px"></asp:ListBox>
    </div>
    <div class="auto-style9">
        CheckBoxList<br />
        <div class="auto-style12">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Height="262px" Width="282px">
                <asp:ListItem Value="3000">배 (3000원)</asp:ListItem>
                <asp:ListItem Value="5000">바나나 (5000원)</asp:ListItem>
                <asp:ListItem Value="2000">감 (2000원)</asp:ListItem>
                <asp:ListItem Value="4500">메론 (4500원)</asp:ListItem>
                <asp:ListItem Value="1500">키위 (1500원)</asp:ListItem>
                <asp:ListItem Value="2500">망고 (2500원)</asp:ListItem>
                <asp:ListItem Value="1000">토마토 (1000원)</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <br />
        <div class="auto-style12">
        </div>
    </div>
    <div class="auto-style8">
        <div class="auto-style11">
            RadioButtonList<br />
            <div class="auto-style12">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="259px" Width="244px">
                    <asp:ListItem Value="5000">수박 (5000원)</asp:ListItem>
                    <asp:ListItem Value="4000">파인애플 (4000원)</asp:ListItem>
                    <asp:ListItem Value="4500">딸기 (4500원)</asp:ListItem>
                    <asp:ListItem Value="3000">사과 (3000원)</asp:ListItem>
                    <asp:ListItem Value="2500">오렌지 (2500원)</asp:ListItem>
                    <asp:ListItem Value="2000">포도 (2000원)</asp:ListItem>
                    <asp:ListItem Value="1000">귤 (1000원)</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
    </div>
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
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style13" OnClick="Button1_Click" Text="초기화" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style14" OnClick="Button2_Click" Text="계산" />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style15" Text="총 가격 : "></asp:Label>
    </p>
</asp:Content>
