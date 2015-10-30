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