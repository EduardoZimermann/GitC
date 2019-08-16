select temp.*,iif(temp.Media >= 5,'Aprovado','Reprovado') as 'Status' from
(select
	Nome,
	Materia,
	Nota1,
	Nota2,
	Nota3,
	Nota4,
	Nota5,
	Nota6,
	((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) as 'Media'
	from Notas) temp;