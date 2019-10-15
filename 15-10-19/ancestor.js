
$(document).ready(function(){
    $("button").click(function(){
        $("span").parents().css({"color":"red","border":"2px solid green"});
    });
  });