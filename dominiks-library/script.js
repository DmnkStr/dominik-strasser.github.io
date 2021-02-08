//$.getJSON("data.json", function(json) {
//    console.log(json); // this will show the info it in firebug console
//});

$(document).ready(function(){
  $.getJSON("https://raw.githubusercontent.com/Dominik-Strasser/Dominik-Strasser.github.io/master/dominiks-library/data.json", function(data) {
    console.log(data);

  });

});
