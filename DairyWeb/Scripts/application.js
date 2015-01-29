/// <reference path="jquery-1.10.2.js" />
/// <reference path="jquery-1.10.2.intellisense.js" />
$(function () {
 
    $(".RateStare").on("click", function () {
        console.log("enter");
        var number = $(this).data("number");
        debugger;
        $("#Rate").val(number);
        for (var i = 1; i <= 6; i++) {
            if (i <= number) {
                $('#str' + i).attr("src", "/Content/Images/knewstuff.png");
            } else {
                $('#str' + i).attr("src", "/Content/Images/14_star.png");
            }
        }
    });

});