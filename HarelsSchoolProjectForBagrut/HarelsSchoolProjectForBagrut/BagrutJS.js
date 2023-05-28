function emailCheck(emailID) {
    var email = document.getElementById(emailID);
    var errorBox = document.getElementById("ErrorSummary");

    var firstAt = email.value.indexOf('@');
    var lastAt = email.value.lastIndexOf('@');
    var dot = email.value.lastIndexOf('.');
    if (email.value.length == 0 || firstAt != lastAt || firstAt == -1 || dot <= firstAt + 1 || email.value.length == dot) {
        errorBox.innerHTML = errorBox.innerHTML + "invalid email!" + "<br/>";
        email.style.backgroundColor = "red";

        return false;
    }

    email.style.backgroundColor = "white";
    return true;
}

function passCheck(pass) {
    var password = document.getElementById(pass);
    var validion = 0;
    var errorBox = document.getElementById("ErrorSummary");

    if (password.value.length < 5) {
        validion++;
    }
    for (var i = 0; i < password.value.length; i++) {
        if ((password.value.charAt(i) >= 'א') && (password.value.charAt(i) <= 'ת')) {
            validion++;
        }

    }

    if (validion > 0) {
        errorBox.innerHTML = errorBox.innerHTML + "password invalid!" + "<br/>";
        password.style.background = "red";

        return false;
    }
    password.style.background = "white";
    return true;
}

function passAuthCheck(passAuth) {
    var passwordAuth = document.getElementById(passAuth);
    var password = document.getElementById("pw"); 
    var errorBox = document.getElementById("ErrorSummary");

    if (password.value != passwordAuth.value) {
        passwordAuth.style.backgroundColor = "red";
        errorBox.innerHTML = errorBox.innerHTML + "your password's auth isn't matching with your password" + "<br/>";

        return false;
    }
    passwordAuth.style.backgroundColor = "white";
    return true;
}

function hobbiesCheck(hobbiesID) {
    var hobbies = document.getElementById(hobbiesID);
    var selectedValue = hobbies.options[hobbies.selectedIndex].value;
    var errorBox = document.getElementById("ErrorSummary");

    if (selectedValue == "בחר את התחביבים שלך:") {
        errorBox.innerHTML = errorBox.innerHTML + "please choose a hobbie" + "<br/>";

        return false;
    }
    
    return true;
}

function checkGender() {
    var male = document.getElementById("male");
    var female = document.getElementById("female");
    var other = document.getElementById("otherGender");
    var errorBox = document.getElementById("ErrorSummary");

    if ((male.checked == false) && (female.checked == false) && (other.checked == false)) {
        errorBox.innerHTML = errorBox.innerHTML + "invalid gender" + "<br/>";

        return false;

    }
    return true;
}

function checkDate() {

    var date = document.getElementById("birthdate");
    var errorBox = document.getElementById("ErrorSummary");

    if (date.value == "") {
        date.style.backgroundColor = "red";
        errorBox.innerHTML = errorBox.innerHTML + "please choose a date" + "<br/>";

        return false;
    } else {
        date.style.backgroundColor = "white";
        return true;
    }
}

function nameCheck() {
    var name = document.getElementById("name");
    var errorBox = document.getElementById("ErrorSummary");

    if (name.value.length < 1 || name.value.length > 50) {
        name.style.backgroundColor = "red";
        errorBox.innerHTML = errorBox.innerHTML + "invalid name length! (need to be between 1-50)" + "<br/>";

        return false;
    } else {
        name.style.backgroundColor = "white";
        return true;
    }
}


function testValidation() {
    var errorBox = document.getElementById("ErrorSummary");
    errorBox.innerHTML = "";
    var firstnameValid = nameCheck();
    var emailValid = emailCheck("email");
    var passwordValid = passCheck("pw");
    var passwordAuthValid = passAuthCheck("passAuth");
    var genderValid = checkGender();
    var hobbiesValid = hobbiesCheck("hobbies");
    var dateValid = checkDate();

    if (firstnameValid == false || emailValid == false || passwordValid == false || passwordAuthValid == false || genderValid == false || hobbiesValid == false || dateValid == false) {

        return false;
    } else {

        return true;
    }
}


function submitSeriesValidation() {
    alert("running");
    var errorBox = document.getElementById("ErrorSummary");
    errorBox.innerHTML = "";
    var seriesBox = document.getElementById("SeriesName");
    if (seriesBox.value.length == 0) {
        errorBox.innerHTML = errorBox.innerHTML + "Enter a valid series name!";
        return false;
    }
    return true;
}