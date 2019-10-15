
$(document).ready(function(){
    $("button").click(function(){
        $("span").siblings().css({"color":"red","border":"2px solid green"});
        $("p").siblings("h1").css({"color":"green","border":"2px solid red"});
        $("p").next("h1").css({"color":"purple","border":"2px solid pink"});
       
    });
  });