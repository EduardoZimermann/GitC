	var generoList;
	var editoraList;

    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		CarregaInformacoes();
	});
    
    function GetMethod(object){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Livros",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
				}

				$.ajax(settings).done(function (response) {
				  RefreshGrid(response);
				});
			
			return false;
	}
	
	function RetornaString(id, listName, fieldName){

		var retorno;

		$.each(listName,function(index, value){
			if(value.Id == id)
				retorno = value[fieldName];
		});

		return retorno;
	}
   
    function RefreshGrid(contentValue){
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Registro</th>'
							+ 		'<th>Título</th>'
							+ 		'<th>Isbn</th>'
							+ 		'<th>Genero</th>'
                            + 		'<th>Editora</th>'
                            + 		'<th>Sinopse</th>'
                            + 		'<th>Observacoes</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
                        + '<td>' + value.Registro    + '</td>'
                        + '<td>' + value.Titulo    + '</td>'
						+ '<td>' + value.Isbn    + '</td>'
						+ '<td>' + RetornaString(value.Genero,generoList,'Tipo')    + '</td>'
                        + '<td>' + RetornaString(value.Editora,editoraList,'Nome')    + '</td>'
                        + '<td>' + value.Sinopse    + '</td>'
                        + '<td>' + value.Observacoes    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax btn-delet-event\' type=\'button\' send-post="Livros"  value="' + value.Id + '">Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3 btn-editing-event\' send-post="Livros" value="' + value.Id + '" type=\'button\'>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});

		SetGridClickEvents();
	}
	
	function CarregaInformacoes(){
		var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Generos",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}

		$.ajax(settings).done(function (response) {
			generoList = response;

			$.each(response,function(index,value){
				var generoRow = '<option value="' + value.Id+ '">' + value.Tipo + '</option>';
				$('#Genero').append(generoRow);
			});
		});

		var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Editoras",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}

		$.ajax(settings).done(function (response) {
			editoraList = response;

			$.each(response,function(index,value){
				var editoraRow = '<option value="' + value.Id + '">' + value.Nome + '</option>';
				$('#Editora').append(editoraRow);
			});

			GetMethod(null);
		});
	}
	
	
  
  