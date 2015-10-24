/// <reference path="jquery-1.10.2.intellisense.js" />


$(document).ready(function () {
    $("#UserType").val("User");
});


function userClick() {
    $("#user").css("border-color", "#5E7EA5");
    $("#chef").css("border-color", "#3A3737");
    $("#db").css("border-color", "#3A3737");
    $("#UserType").val("User");
    $("#displayType").text("User");
    $("#displayType").show("slow");

}

function chefClick() {
    $("#chef").css("border-color", "#5E7EA5");
    $("#user").css("border-color", "#3A3737");
    $("#db").css("border-color", "#3A3737");
    $("#UserType").val("Chef");
    $("#displayType").text("Chef");
    $("#displayType").show("slow");
}

function dbClick() {
    $("#db").css("border-color", "#5E7EA5");
    $("#chef").css("border-color", "#3A3737");
    $("#user").css("border-color", "#3A3737");
    $("#UserType").val("Delivery");
    $("#displayType").text("Delivery");
    $("#displayType").show("slow");
}