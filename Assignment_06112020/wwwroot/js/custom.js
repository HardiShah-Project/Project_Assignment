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
        url: '<%=Url.Action("Delete")%>',
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
        url: '<%=Url.Action("Delete")%>',
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
            var ctx = document.getElementById('myChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: 'JoiningDate Count',
                        backgroundColor: ['rgba(145,65,72,.5)', 'rgba(242,166,54,.5)', 'rgba(145,65,72,.5)', 'rgba(242,166,54,.5)'],
                        borderColor: 'rgba(145,65,72,.3)',
                        data: counts,
                        borderWidth:1
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
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
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: 'ReleaseDate Count',
                        backgroundColor: ['rgba(255, 127, 80,.5)', 'rgba(145,65,72,.5)', 'rgba(255, 127, 80,.5)', 'rgba(145, 65, 72,.5)'],
                        borderColor: 'rgba(255, 99, 132,.3)',
                        data: counts
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
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
        url: "./Dashboard/StartDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('StartChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: 'StartDate Count',
                        backgroundColor: ['rgba(145,65,72,.5)', 'rgba(242,166,54,.5)', 'rgba(145,65,72,.5)', 'rgba(242,166,54,.5)'],
                        borderColor: 'rgba(145,65,72,.3)',
                        data: counts
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
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
        url: "./Dashboard/EndDate",
        data: { type: $(this).attr("data-type") },
        contentType: "application/json",
        success: function (response) {
            console.log(response.result);
            var counts = response.result.map(x => x.count);
            var months = response.result.map(x => x.month);
            var ctx = document.getElementById('EndChart').getContext('2d');
            var chart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: months,
                    datasets: [{
                        label: 'EndDate Count',
                        backgroundColor: ['rgba(255, 127, 80,.5)', 'rgba(145,65,72,.5)', 'rgba(255, 127, 80,.5)', 'rgba(145, 65, 72,.5)'],
                        borderColor: 'rgba(255, 99, 132,.3)',
                        data: counts
                    }]
                },
                options: {
                    scales: {
                        xAxes: [{
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
});
