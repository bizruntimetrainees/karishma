
$(document).ready(function(){
    $("button").click(function(){
        $("l1").find("span").css({"color":"red","border":"2px solid green"});
        $("div").children().css({"color":"green","border":"2px solid red"});
        $("div").find("p").css({"color":"blue","border":"2px solid black"});
    });
  });