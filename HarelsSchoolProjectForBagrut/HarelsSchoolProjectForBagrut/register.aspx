<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="HarelsSchoolProjectForBagrut.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form method="post" onsubmit="return testValidation()" id="register">

            <label for="firstname">שם: </label>
            <input type="text" id="name" name="name" class="inputBox"><br/><br/>

            <label for="email">אימייל: </label>
            <input type="text" id="email" name="email" class="inputBox"><br/><br/>

            <label for="password">סיסמה: </label>
            <input type="password" id="pw" name="pw" class="inputBox"><br/><br/>
            
            <label for="passwordAuth">אימות סיסמה: </label>
            <input type="password" id="passAuth" name="passAuth" class="inputBox"><br/><br/><br/>
            
            <label for="chooseGender">בחר את המגדר שלך: </label><br/>
            <input type="radio" name="gender" value="male" id="male"> גבר<br/>
            <input type="radio" name="gender" value="female" id="female"> אישה<br/>
            <input type="radio" name="gender" value="otherGender" id="otherGender"> אחר<br/><br/>

            <select id="hobbies" name="hobbies">
                <option>בחר את התחביבים שלך:</option>
                <option value="videoGames">לשחק במשחקי מחשב</option>
                <option value="sport">לעשות ספורט</option>
                <option value="develop">לתכנת</option>
                <option value="trips">לטייל</option>
                <option value="eating">לאכול</option>
                <option value="study">ללמוד</option>
                <option value="other">אחר</option>
            </select><br/><br/>

            <input type="date" id="birthdate" name="birthdate" min="1987-01-01" max="2022-12-31">   :בחר תאריך יום הולדת<br/><br/>

            <input type="submit" value="שלח" name="submit">
            <input type="reset" value="נקה טופס"><br/><br/>
            <div id="ErrorSummary" class="errorBox"></div>
        </form>
        
    <%=msg %>
</asp:Content>
