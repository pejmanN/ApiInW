
const apiUrl = "http://localhost:3144/api/";

function PersonList() {
    $.ajax({
        type: "GET",
        url: apiUrl + "Person/",
        contentType: "json",
        dataType: "json",
        success: function (data) {
            $("#persons").css("visibility", "visible");
            $.each(data, function (i, value) {
                $("#persons").append($("<tr><td>" + value.Id + "</td><td>" + value.Name + "</td>"));
            });
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}
