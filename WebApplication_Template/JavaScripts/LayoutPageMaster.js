/*
*Author: Czar Art Z. Duran
*Email: czarartduran@live.com.ph
*Contact No: +63 917 328 2308
*/

$(document).ready(function () {
    document_OnLoad();
    hideload();
});

$(window).resize(function () {
    document_OnLoad();
});

window.onresize = document_OnLoad();

function document_OnLoad() {
    console.log("clicker");
    var body_height = $('#main_body').height();
    var bannav_height = $('#bannernav_container').height();
    $('#webApp_body').height(body_height - bannav_height);
}

function hideload() {
    console.log("clicker");
    $('#loading_container').fadeOut("slow");
}

function showload() {
    console.log("clicker");
    $('#loading_container').fadeIn("slow");
}