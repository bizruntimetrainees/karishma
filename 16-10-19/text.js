$(document).ready(function(){
    $("button").click(function(){
        $("h1").text("concept changed ").css({"color":"red","border":"2px solid light"});
        $("p#ram").text("concept changed ").css({"color":"blue","border":"2px solid pink"});
        alert($("p#ram").text( )).css({"color":"red","border":"2px solid blue"});
    });
  });