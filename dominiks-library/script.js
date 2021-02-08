//$.getJSON("data.json", function(json) {
//    console.log(json); // this will show the info it in firebug console
//});

$(document).ready(function(){
  //alert("Hello");

  $.getJSON("https://dominik-strasser.github.io/dominiks-library/data.json", function(json) {
      alert(json); // this will show the info it in firebug console
  });

});
