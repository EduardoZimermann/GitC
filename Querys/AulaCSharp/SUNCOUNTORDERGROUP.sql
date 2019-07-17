select
		Nome,
		Materia,
		(SUM(Nota) / COUNT(Nota)) as 'Média',
		Count(Nota) as 'Provas'
	from NotaAlunos
	group by Nome,Materia
	order by Nome asc