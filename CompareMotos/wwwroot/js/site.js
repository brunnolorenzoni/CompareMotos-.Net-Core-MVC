﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var buildCompare = function (data)
{

    var data = [
        {
            "motorcycleId": 1,
            "year": 2019,
            "price": 15000,
            "length": 10000,
            "width": 10000,
            "height": 10000,
            "weight": 10000,
            "typeMotorcycleId": 1,
            "typeMotorcycle": null,
            "brandId": 1,
            "brand": null,
            "modelMotorcycleId": 1,
            "modelMotorcycle": null,
            "displacementId": 1,
            "displacement": null
        },
        {
            "motorcycleId": 1,
            "year": 2019,
            "price": 15000,
            "length": 10000,
            "width": 10000,
            "height": 10000,
            "weight": 10000,
            "typeMotorcycleId": 1,
            "typeMotorcycle": null,
            "brandId": 1,
            "brand": null,
            "modelMotorcycleId": 1,
            "modelMotorcycle": null,
            "displacementId": 1,
            "displacement": null
        },

    ]

    console.log(data)


    $(".comparation-container").html('');

    var i;
    for (i = 0; i < data.length; i++) {

        var html =
            '<div class="card">' +

            '<h2 class="title">' + data[i].modelMotorcycle + '</h2>' +

            '<p class="info brand">' +
                '<span class="label">Marca: </span> ' +
                '<span class="content">' + data[i].brand + '</span>' +
            '</p>' +
            '<p class="info type">' +
                '<span class="label">Tipo: </span> ' +
                '<span class="content">' + data[i].typeMotorcycle + '</span>' +
            '</p>' +
            '<p class="info year">' +
                '<span class="label">Ano: </span>' +
                '<span class="content">' + data[i].year + '</span>' +
            '</p>' +
            '<p class="info price">' +
                '<span class="label">Preço: </span> ' +
                '<span class="content">' + data[i].price + '</span>' +
            '</p>' +
            '<p class="info length">' +
                '<span class="label">Comprimento: </span> ' +
                '<span class="content">' + data[i].length + '</span>' +
            '</p>' +
            '<p class="info width">' +
                '<span class="label">Largura: </span> ' +
                '<span class="content">' + data[i].width + '</span>' +
            '</p>' +
            '<p class="info height">' +
                '<span class="label">Altura: </span> ' +
                '<class="content">' + data[i].height + '</span>' +
            '</p>' +
            '<p class="info weight">' +            
                '<span class="label">Tipo: </span> ' +
                '<span class="content">' + data[i].weight + '</span>' +
            '</p>' +
        '</div>';

        $(".comparation-container").append(html)
    }




}

var compararMotos = function (e) {

    e.preventDefault();

    var data = {

        'nameA': $('#compare1').val(),
        'nameB': $('#compare2').val(),

    }

    var request = $.ajax({
        url: '/api/motorcycle/compare',
        data: data,
        dataType: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            buildCompare(data)
        },
        error: function (response) {
            alert("Erro ao pesquisar motos");
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

    $('.form-compare').on('submit', compararMotos);
}

var init = function () {

    bind();

    buildCompare();

}

$(document).ready(init);