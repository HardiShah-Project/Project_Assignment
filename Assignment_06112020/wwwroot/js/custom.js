function addProject() {
    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: '<%=Url.Action("Create")%>',
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
            url: '<%=Url.Action("Edit")%>',
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
        url:"./Employee/Delete",
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
        url:"./Project/Delete",
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
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('JoiningChart').getContext('2d');
            var JoiningChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: ' Employee Joining ',
                        backgroundColor:'rgba(145,65,72,.3)',
                        borderColor: 'rgba(145,65,72,.8)',
                        data: counts,
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
                            maxBarThickness: 65,
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }],
                        yAxes: [{
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }]
                    }
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
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('ReleaseChart').getContext('2d');
            var ReleaseChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: ' Employee Release',
                        backgroundColor: 'rgba(145,65,72,.3)',
                        borderColor: 'rgba(145,65,72,.8)',
                        data: counts,
                        borderWidth:1
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
                            maxBarThickness: 65,
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }],
                        yAxes: [{
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }]
                    }
                }
            });
            $('#tab2').hide();
        }
    });

    $.ajax({
        type: "GET",
        url: "./Dashboard/StartDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('StartChart').getContext('2d');
            var StartChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: ' Project Start',
                        backgroundColor: 'rgba(145,65,72,.3)',
                        borderColor: 'rgba(145,65,72,.8)',
                        data: counts,
                        borderWidth:1
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
                            maxBarThickness: 65,
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }],
                        yAxes: [{
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }]
                    }
                }
            });
            $('#tab3').hide();
        }
    });

    $.ajax({
        type: "GET",
        url: "./Dashboard/EndDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('EndChart').getContext('2d');
            var EndChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: ' Project End',
                        backgroundColor: 'rgba(145,65,72,.3)',
                        borderColor: 'rgba(145,65,72,.8)',
                        data: counts,
                        borderWidth:1
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
                            maxBarThickness: 65,
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }],
                        yAxes: [{
                            gridLines: {
                                display: false},

                            ticks: {
                                beginAtZero: true}
                        }]
                    }
                }
            });
            $('#tab4').hide();
        }
    });
});
$('#tab1btn').on('click', function () {
    $('#tab1').show();
    $('#tab2').hide();
    $('#tab3').hide();
    $('#tab4').hide();
})
$('#tab2btn').on('click', function () {
    $('#tab1').hide();
    $('#tab3').hide();
    $('#tab4').hide();
    $('#tab2').show();
})
$('#tab3btn').on('click', function () {
    $('#tab1').hide();
    $('#tab2').hide();
    $('#tab4').hide();
    $('#tab3').show();
})
$('#tab4btn').on('click', function () {
    $('#tab1').hide();
    $('#tab2').hide();
    $('#tab3').hide();
    $('#tab4').show();
})

