/// <reference path="jquery-1.10.2.js" />
/// <reference path="jquery-1.10.2.intellisense.js" />
$(function () {

    //(function () {
    //    var number = 0;
    //    debugger;
    //    var rate = $("#item_Rate").val();
    //    if (rate && rate != "") {
    //        number = $("#item_Rate").val();
    //        for (var i = 1; i <= 6; i++) {
    //            if (i <= number) {
    //                $('#str' + i).attr("src", "/Content/Images/knewstuff.png");
    //            } else {
    //                $('#str' + i).attr("src", "/Content/Images/14_star.png");
    //            }
    //        }
    //    }
    //})();

    $('#adel').click(function (e) {    
        var answer = confirm("Сигурни ли сте,че искате да изтриете история?");
        debugger;
        if (!answer) {
            e.preventDefault();
            // do the default action
        }
    });
});