<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="logIn.aspx.cs" Inherits="HarelsSchoolProjectForBagrut.logIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form name="loginFrm" id="loginFrm" method="post" runat="server">
        <br /><br />
        <table id="table1" dir="rtl" align="center">
            <tr>
                <td>שם משתמש:</td>
                <td><input type="text" name="uName" id="uName" class="inputBox"/></td>
            </tr>
            <tr>
                <td>סיסמה:</td>
                <td><input type="password" name="pw" id="pw" class="inputBox"/></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <input type="submit" name="submit" value="התחבר" class="important"/>
                </td>
            </tr>
        </table>
        <% =msg %>
    </form>
</asp:Content>
