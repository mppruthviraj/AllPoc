$(document).ready(function () {
    $(".clickClass").css("background-color", "red")
    $(document).attr("title", "Test From Jquery")
    var count = $("div").size()
    alert(count);
    $("p").click(function () {
        $(this).hide();
    });

    });

$(document).ready(function () {
    $(".dropdown-menu").hover(
        function () {
            $(".menu-items",this).slideDown(100);
        },
        function () {
            $(".menu-items",this).slideUp(100);
        }
        );

});

function ShowCurrentTime() {
    //alert($("#<%= txtUserName.ClientID %>").val());
    $.ajax({
        type: "POST",
        url: "Default.aspx/GetText",
        data: '{name: "me" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (htmlText) {
            $("#span1").html(htmlText.d);
        },
        failure: function (response) {
            $("#span1").html(response.d);
        }
    });
}
function OnSuccess(response) {
    alert(response.d);
}

function CallAjax() {
    $.ajax({
        type: "POST",
        url: "Default.aspx/WebTestMethod",
        data: '{name: "raj" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (htmlText) {
            $("#span1").html(htmlText.d);
        },
        failure: function (response) {
            $("#span1").html(response.d);
        }
    });

    return true;
}