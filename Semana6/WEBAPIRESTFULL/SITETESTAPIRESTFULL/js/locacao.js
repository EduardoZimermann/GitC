	var livroList;
	var usuarioList;

    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		CarregaInformacoes();
	});
    
    function GetMethod(object){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Locacaos",
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
	
	function RetornaString(id, tableName, fieldName){

		var retorno;

		$.each(tableName,function(index, value){
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
							+ 		'<th>Livro</th>'
							+ 		'<th>Usuario</th>'
							+ 		'<th>Tipo</th>'
                            + 		'<th>Devolucao</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
                        + '<td>' + RetornaString(value.Livro,livroList,'Titulo')    + '</td>'
                        + '<td>' + RetornaString(value.Usuario,usuarioList,'Nome')    + '</td>'
						+ '<td>' + value.Tipo    + '</td>'
						+ '<td>' + value.Devolucao    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax btn-delet-event\' type=\'button\' send-post=\'Locacaos\' value=\''+ value.Id +'\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3 btn-editing-event\'    type=\'button\' send-post=\'Locacaos\' value=\''+ value.Id +'\'>Editar</button>'
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
			"url": "http://localhost:59271/Api/Livros",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}

		$.ajax(settings).done(function (response) {
		  livroList = response;

		  $.each(response,function(index,value){
			var livroRow = '<option value="' + value.Id + '">' + value.Titulo + '</option>';
			$('#Livro').append(livroRow);
		  });
		});

		var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Usuarios",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}

		$.ajax(settings).done(function (response) {
		  usuarioList = response;

		  $.each(response,function(index,value){
			var usuarioRow = '<option value="' + value.Id + '">' + value.Nome + '</option>';
			$('#Usuario').append(usuarioRow);
		  });

		  GetMethod(null);
		});
	}
	
  
  