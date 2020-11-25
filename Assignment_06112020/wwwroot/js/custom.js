function addProject() {
    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: "../Project/Create",
            data: $('#form').serialize(),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert(data);
            }
        });
}
function EditProject() {
    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: "../Project/Edit",
            data: $('#Form').serialize(),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert(data);
            }
        });
}

var ConfirmDelete = function (id) {
    $("#hiddenId").val(id);
    $("#MyModal").modal("show");
}
var DeleteEmployee = function () {
    var medId = $("#hiddenId").val();
    $.ajax({
        type: "POST",
        url: "../Employee/Delete",
        data: { id: medId },
        success: function (result) {
            $("#MyModal").modal("hide");
            $("#row_" + medId).remove();
        }
    })
}
var Confirmdelete = function (id) {
    $("#hiddenId").val(id);
    $("#MyModal").modal("show");
}

var DeleteProject = function () {
    var medId = $("#hiddenId").val();
    $.ajax({
        type: "POST",
        url: "../Project/Delete",
        data: { id: medId },
        success: function (result) {
            $("#MyModal").modal("hide");
            $("#row_" + medId).remove();
        }
    })
}
$(function () {
    $('.datepicker').datepicker({
        dateFormat: "dd/mm/yy",
        picktime: false,
        format: 'L',
        locale: 'fr',
        changeMonth: true,
        changeYear: true
    });
});
//Dashboard.js
$(".viewDetails").click(function () {
    $(".modal-body").html('');
    $.ajax({
        type: 'GET',
        url: "./Dashboard/GetDetails",
        data: { type: $(this).attr("data-type") },
        success: function (response) {
            $(".modal-body").html(response);
            $("#exampleModal").modal('show');
        },
        error: function () {
            alert("Something wrong");
        }
    });
});
$(".ProjectDetails").click(function () {
    $(".modal-body").html('');
    $.ajax({
        type: 'GET',
        url: "./Dashboard/GetProject",
        data: { type: $(this).attr("data-type") },
        success: function (response) {
            $(".modal-body").html(response);
            $("#ProjectModal").modal('show');
        },
        error: function () {
            alert("Something wrong");
        }
    });
});
$(".EmpSkillDetails").click(function () {
    $(".modal-body").html('');
    $.ajax({
        type: 'GET',
        url: "./Dashboard/EmployeeSkill",
        data: { type: $(this).attr("data-type") },
        success: function (response) {
            $(".modal-body").html(response);
            $("#EmpSkillModal").modal('show');
        },
        error: function () {
            alert("Something wrong");
        }
    });
});
$(".PrjSkillDetails").click(function () {
    $(".modal-body").html('');
    $.ajax({
        type: 'GET',
        url: "./Dashboard/ProjectSkill",
        data: { type: $(this).attr("data-type") },
        success: function (response) {
            $(".modal-body").html(response);
            $("#PrjSkillModal").modal('show');
        },
        error: function () {
            alert("Something wrong");
        }
    });
});
$(function () {
    $.ajax({
        type: "GET",
        url: "./Dashboard/JoiningDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response);
            var ctx = document.getElementById('myChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['January', 'February', 'March', 'April'],
                    datasets: [{
                        label: 'JoiningDate Dataset',
                        backgroundColor: 'blue',
                        borderColor: 'blue',
                        data: [2, 0, 4, 3]
                    }]
                }
            });
        }
    });

    $.ajax({
        type: "GET",
        url: "./Dashboard/ReleaseDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response);
            var ctx = document.getElementById('ReleaseChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['January', 'February', 'March', 'April'],
                    datasets: [{
                        label: 'ReleaseDate Dataset',
                        backgroundColor: 'rgb(255, 99, 132)',
                        borderColor: 'rgb(255, 99, 132)',
                        data: [0, 2, 1, 3]
                    }]
                }
            });
        }
    });

    $.ajax({
        type: "GET",
        url: "./Dashboard/StartDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response);
            var ctx = document.getElementById('StartChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['January', 'February', 'March', 'April'],
                    datasets: [{
                        label: 'StartDate Dataset',
                        backgroundColor: 'blue',
                        borderColor: 'blue',
                        data: [1, 3, 4, 0]
                    }]
                }
            });
        }
    });

    $.ajax({
        type: "GET",
        url: "./Dashboard/EndDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response);
            var ctx = document.getElementById('EndChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['January', 'February', 'March', 'April'],
                    datasets: [{
                        label: 'EndDate Dataset',
                        backgroundColor: 'rgb(255, 99, 132)',
                        borderColor: 'rgb(255, 99, 132)',
                        data: [3, 1, 0, 2]
                    }]
                }
            });
        }
    });
});
