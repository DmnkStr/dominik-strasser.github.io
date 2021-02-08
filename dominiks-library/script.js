//$.getJSON("data.json", function(json) {
//    console.log(json); // this will show the info it in firebug console
//});

$(document).ready(function(){
  $.getJSON("https://raw.githubusercontent.com/Dominik-Strasser/Dominik-Strasser.github.io/master/dominiks-library/data.json", function(data) {

    for (i = 0; i < data.materials.length; i++) {
      var name = data.materials[i].name;
      var folder = name.replace(/ /g, '-').toLowerCase();
      $("#container").append(name + ' - <figure class="image is-128x128"><img src="materials/' + folder + '/thumbnail.png"></figure><br>');
    }


  })
  .fail(function(error) {
    console.log("error");
  })

});
