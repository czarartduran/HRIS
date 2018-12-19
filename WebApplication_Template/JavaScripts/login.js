/*
*Author: Czar Art Z. Duran
*Email: czarartduran@live.com.ph
*Contact No: +63 917 328 2308
*/

$(document).ready(function () {
    hideload();
});

function hideload() {
    $('#loading_container').fadeOut("slow");
}

function showload() {
    $('#loading_container').fadeIn("slow");
}

function forgotpass_tb_OnClick() {
    showload();
    /*
    something to do here
    */


    hideload();
}

function login_btn_OnClick() {
    showload();
    /*
    something to do here
    */
    window.location = "/sample/index";

    hideload();
}

function cancel_btn_OnClick() {
    showload();
    $('#username_tb, #password_tb').val("");
    hideload();
}

$(document).keyup(function (e) {
    if ($('#username_tb').is(":focus") || $('#password_tb').is(":focus")) {
        if (e.keyCode == 13) {
            login_btn_OnClick();
        }
    }
});