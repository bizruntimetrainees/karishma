$(document).ready(function(){
    $("#b1").click(function(){
        $("p").remove("#color").css({"color":"blue","border":"2px solid pink"});
        $("p1").remove("#head").css({"color":"red","border":"2px solid pink"});
    });
});