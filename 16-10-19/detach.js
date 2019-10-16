$(document).ready(function(){
    var x;
    $("#b1").click(function(){
       x= $("div").detach();

    });
    $("#b2").click(function(){
        $("p").prepend(x).css({"color":"blue","border":"2px solid pink"});
    });



});