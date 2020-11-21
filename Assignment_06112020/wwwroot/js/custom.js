function addEmpProject() {
    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: "/EmpProject/Create",
            data: $('#form').serialize(),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert(data);
            }
        });
}
function EditEmpProject() {
    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: "/EmpProject/Edit",
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
        url: "/Employee/Delete",
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

var DeleteEmpProject = function () {
    var medId = $("#hiddenId").val();
    $.ajax({
        type: "POST",
        url: "/EmpProject/Delete",
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
        url: "/Dashboard/GetDetails",
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
        url: "/Dashboard/GetProject",
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
        url: "/Dashboard/EmployeeSkill",
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
        url: "/Dashboard/ProjectSkill",
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
