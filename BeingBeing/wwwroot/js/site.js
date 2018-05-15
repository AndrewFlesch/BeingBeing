// Write your Javascript code.

//Get Day and Time and default location

function setDefaultTemperature() {
    let month = new Date().getMonth();
    if (month <= 3 && month == 11) {
        $("#temperature").val("Cold");
        $('[value="Cold"]').addClass("feelselect");
    }
    else if (month >= 4 && month <= 5) {
        $("#temperature").val("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
        }
    else if (month >= 6 && month <= 7) {
        $("#temperature").val("Warm");
        $('[value="Warm"]').addClass("feelselect");
    }
    else {
        $("#temperature").val("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
}
};

function defaultLocation() {
    let isweekday = new Date().getDay();
    if (isweekday != 0 && 1) {
        let isworktime = new Date().getHours();
        if (isworktime >= 9 && isworktime <= 17) {
            $("#location").val("Work");
            $('[value="Work"]').css("border", "1px solid black");
        }
        else {
            $("#location").val("Home");
            $('[value="Home"]').css("border", "1px solid black");
        };

    };
};

var elem2 = document.getElementById("findout");
var timeout = setTimeout(findout, 6000);
function findout() {
    elem2.style = "display:inline;"
}

var text = ["Great", "Sad", "Productive"];
var counter = 0;
var elem = document.getElementById("changeText");
var inst = setInterval(change, 2000);

function change() {
    elem.innerHTML = text[counter];
    counter++;
    if (counter >= text.length) {
        counter = 0;
        clearInterval(inst);
    }
}

$(".stateinput .btn").click(function () {
    defaultLocation();
    setDefaultTemperature();
    $("#stateform").css("display", "block");
    $("#statetitle").val($(this).val());
    $("#datestate").val(moment().format('YYYY-MM-DDTHH:mm:ss'));
    $(this).addClass("feelselect");
    
});

$(".weather .btn").click(function () {
    $(".weather button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $("#weather").val($(this).val());
});

$(".temperature .btn").click(function () {
    $(".temperature button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $("#temperature").val($(this).val());
});

$(".locationbuttons .btn").click(function () {
    $(".locationbuttons button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $("#location").val($(this).val());
});

$("#close").click(function () {
    $("#stateform").css("display", "none");
    });