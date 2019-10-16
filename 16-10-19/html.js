$(document).ready(function(){
    $("button").click(function(){
        $("p").html("hello<b>kumar</b> ").css({"color":"black","border":"2px solid light"});
        $("h1").html("hello").css({"color":"blue","border":"2px solid pink"});
        alert($("p").html( ));
    });
  });