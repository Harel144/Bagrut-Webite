<%@ Page Title="הצע סדרה" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SuggestSeries.aspx.cs" Inherits="HarelsSchoolProjectForBagrut.SuggestSeries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form name="suggestFrm" id="suggestFrm" method="post" runat="server" onsubmit="return submitSeriesValidation()">
        <br /><br />
        <table id="table1" dir="rtl" align="center">
            <tr>
                <td>הכנס שם סדרה שתרצה לראות ביקורת עליה:</td>
                <td><input type="text" name="SeriesName" id="SeriesName" class="inputBox"/></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <input type="submit" name="submit" value="שלח" class="important"/>
                </td>
            </tr>
        </table>
        <div id="ErrorSummary" class="errorBox"></div>
    </form>
    <%=msg %>
</asp:Content>
