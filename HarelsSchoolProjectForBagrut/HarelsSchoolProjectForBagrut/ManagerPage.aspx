<%@ Page Title="Manager page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManagerPage.aspx.cs" Inherits="HarelsSchoolProjectForBagrut.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MANAGER PAGE - מנהלים בלבד</h1>
    <p style='text-align: right;'><u>:רשימת משתמשים</u></p>
    <%=maor %>
    <br /> 

    <p style='text-align: right;'><u>:מחיקת משתמשים</u></p>
    <form name='removeUser' id='removeUser' method='post' runat='server'>
        <br /><br />
        <table id='table1' dir='rtl' align='center'>
            <tr>
                <td>הכנס את המספר המזהה של המשתמש:</td>
                <td><input type='number' name='id' id='id' class='inputBox'/></td>
            </tr>
            <tr>
                <td colspan='2' align='center'>
                    <input type='submit' name="submit" value="!מחק משתמש - ללא אפשרות שחזור" class="important"/>
                </td>
            </tr>
        </table>

        <table id='table2' dir='rtl' align='center'>
            <tr>
                <td>הכנס את המספר המזהה של המשתמש:</td>
                <td><input type='number' name='adminId' id='adminId' class='inputBox'/></td>
            </tr>
            <tr>
                <td colspan='2' align='center'>
                    <input type='submit' name="submitAdmin" value="!הפוך משתמש לאדמין - לא הפיך" class="important"/>
                </td>
            </tr>
        </table>
    </form>
    <br/>
    <br/>

</asp:Content>
