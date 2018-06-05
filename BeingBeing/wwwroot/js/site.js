// Write your Javascript code.

//Get Day and Time and default location

/* function setDefaultTemperature() {
    let month = new Date().getMonth();
    if (month <= 3 && month == 11) {
        $("#temperature").val("Cold");
        $("#temph3").text("Cold");
        $('[value="Cold"]').addClass("feelselect");
    }
    else if (month >= 4 && month <= 5) {
        $("#temperature").val("Pleasent");
        $("#temph3").text("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
        }
    else if (month >= 6 && month <= 7) {
        $("#temperature").val("Warm");
        $("#temph3").text("Warm");
        $('[value="Warm"]').addClass("feelselect");
    }
    else {
        $("#temperature").val("Pleasent");
        $("#temph3").text("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
}
};


function defaultLocation() {
    let isweekday = new Date().getDay();
    if (isweekday != 0 && 1) {
        let isworktime = new Date().getHours();
        if (isworktime >= 9 && isworktime <= 17) {
            $("#location").val("Work");
            $("#loch3").text("Work");
            $('[value="Work"]').css("border", "1px solid black");
        }
        else {
            $("#location").val("Home");
            $("#loch3").text("Home");
            $('[value="Home"]').css("border", "1px solid black");
        };

    };
};
*/
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

$(".entrysection food .btn").click(function () {
    let item = $(this).val();
    let itemnameqty = item.split(":");
    let itemname = itemnameqty[0];
    let itemqty = itemnameqty[1];
    let headerstring = "I'm " + header;
    $(".modal-title").text(headerstring);
    $("#datestate").val(moment().format('YYYY-MM-DDTHH:mm:ss'));
    $(".stateinput").css("display", "none");
    $(this).addClass("feelselect");
    
});

$(".entrysection .btn").click(function () {
    let header = $(this).val();
    let headerstring = "I'm " + header;
    $(".modal-title").text(headerstring);
    $("#datestate").val(moment().format('YYYY-MM-DDTHH:mm:ss'));
    $(".stateinput").css("display", "none");
    $(this).addClass("feelselect");

});

$(".locationbuttons .btn").click(function () {
    $(".locationbuttons button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $(".locationbuttons").css("display", "none");
    $("#location").val($(this).val());
    $("#loch3").text($(this).val());
});

$("#close").click(function () {
    $("#stateform").css("display", "none");
    });