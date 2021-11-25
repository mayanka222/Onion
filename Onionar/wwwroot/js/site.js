// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//$(document).ready(function () {
//    $('#MyTable').DataTable({
//        columns: [
//            { 'data': 'id' },
//            { 'data': 'name' },
//            { 'data': 'Coures' },
//            { 'data': 'RollNo' },
//            { 'data': 'Batch' },
//        ],
//        "scrollY": "550px",
//        "scrollCollapse": true,
//        "paging": true
//    });
//});
$(document).ready(function () {
    $('#MyTable').DataTable({
        columns: [
        ],
        columns: [
            { 'data': 'id' },
            { 'data': 'name' },
            { 'data': 'Coures' },
            { 'data': 'RollNo' },
            { 'data': 'Batch' },
        ]
    });
});