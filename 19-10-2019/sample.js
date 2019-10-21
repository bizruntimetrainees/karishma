$(document).ready(function(){
    $('#crud').click(function(){
        $("#dropcontent").show();
        $("#dropcontent1").hide();
        $("#dropcontent2").hide();
        
       
        
    });
    $('#header').click(function(){
        $("#dropcontent1").show();
        $("#dropcontent").hide();
        $("#dropcontent").hide();
    });
    $('#athuntication').click(function(){
    $("#dropcontent2").show();
        $("#dropcontent").hide();
        $("#dropcontent1").hide();
    });
    $('#sub').click(function(){
        $("#subdown").show();
            $("#dropcontent").hide();
            $("#dropcontent1").hide();
            $("#dropcontent2").hide();
        });
});
