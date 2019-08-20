
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		
		CarregaInformacoes();

		jQuery('#bntCancelar').click(function(){
			$('#bntCancelar').hide();
			
			$('#Id').val("");
            $('#Registro').val("");
            $('#Titulo').val("");
			$('#Isbn').val("");
			$('#Genero').val("");
            $('#Editora').val("");
            $('#Sinopse').val("");
            $('#Observacoes').val("");
			$('#Ativo select').val("true");
		});
		
		GetMethod(null);
	});
	
	function GetByID(id){
        //$('#bntSubmit').hide();
		//$('#bntSalvar').show();
		$('#bntCancelar').show();
		
        var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Livros/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
                $('#Registro').val(response.Registro);
                $('#Titulo').val(response.Titulo);
				$('#Isbn').val(response.Isbn);
				$('#Genero').val(response.Genero);
                $('#Editora').val(response.Editora);
                $('#Sinopse').val(response.Sinopse);
                $('#Observacoes').val(response.Observacoes);
				$('#Ativo select').val(response.Ativo);
			});
		
	}
    
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
   
    function RefreshGrid(contentValue){
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Registro</th>'
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
						+ '<td>' + value.Genero    + '</td>'
                        + '<td>' + value.Editora    + '</td>'
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
			$.each(response,function(index,value){
				var generoRow = '<option value="' + value.Id+ '">' + value.Tipo + '</option>';
				$('#Genero').append(generoRow);
			});
		});

		var settings2 = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Editoras",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}

		$.ajax(settings2).done(function (response) {
			$.each(response,function(index,value){
				var editoraRow = '<option value="' + value.Id + '">' + value.Nome + '</option>';
				$('#Editora').append(editoraRow);
			});
		});
	}
	
	
  
  