// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




var compararMotos = function () {

    var data = {

        'nameA': $('#compare1').val(),
        'nameB': $('#compare2').val(),

    }

    var request = $.ajax({
        url: '/api/motorcycle/compare',
        data: data,
        dataType: "json",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log(data)
        },
        error: function (response) {
            console.log(response)
        },
    });

}
    
var bind = function () {
    $('#compare1').autocomplete({
        source: '/api/motorcycle/search'
    });

    $('#compare2').autocomplete({
        source: '/api/motorcycle/search'
    });

    $('.btn-compare').on('click', compararMotos);
}

var init = function () {

    bind();

}

$(document).ready(init);