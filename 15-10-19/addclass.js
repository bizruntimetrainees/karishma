$(document).ready(function(){
    $("button").click(function(n){
        $("p").addClass(function(n){
            return("note"+n)
        });
        $("p").addClass(function(n){
            alert("index is"+n)
        });
    });
  });