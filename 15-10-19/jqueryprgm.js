$(document).ready(function(){
    $("button").click(function(){
        $("span").parentsUntil("div").css({"color":"red","border":"2px solid red"});
    });
  });