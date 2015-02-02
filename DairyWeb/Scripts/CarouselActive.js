/// <reference path="bootstrap.js" />
/// <reference path="jquery-1.10.2.js" />
$(function () {
    (function () {
        debugger
        var currentID = $("#storyMIN").val();
       var activUl= $("li").find("[data-slide-to='" + currentID + "']");
       var activDiv = $("div").find("[data-storyid='" + currentID + "']");
       activUl.addClass("active");
       activDiv.addClass("active")
    })();
});