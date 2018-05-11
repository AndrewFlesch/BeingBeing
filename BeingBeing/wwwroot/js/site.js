// Write your Javascript code.

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

$("#b1, #b2, #b3, #b4, #b5, #b6, #b7").click(function () {
    $("#stateform").css("display", "block");
    $("#statetitle").val($(this).val());

});

$("#w1, #w2, #w3, #w4").click(function () {
    $(this).css("border", "solid 1px black")
    $("#weather").val($(this).val());
});

$("#l1, #l2, #l3, #l4").click(function () {
    $(".locationbuttons button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $("#location").val($(this).val());
});

$("#close").click(function () {
    $("#stateform").css("display", "none");
    });