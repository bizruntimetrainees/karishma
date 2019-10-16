$(document).ready(function(){
    $("#b1").click(function(){
        $("#head").append("<b>this is a appended text</b>").css({"color":"blue","border":"2px solid pink"})

    });
    $("#b2").click(function(){
        $("ol1").append("<li> guvva</li>").css({"color":"red","border":"2px solid light"});
    });



});