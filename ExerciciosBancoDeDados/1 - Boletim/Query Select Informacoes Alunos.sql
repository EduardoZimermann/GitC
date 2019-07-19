select
		AL.Nome,
		AL.Idade,
		TU.Serie as 'Turma',
		RE.Nota1,
		RE.Nota2,
		RE.Nota3,
		RE.Nota4,
		(RE.Nota1 + RE.Nota2 + RE.Nota3 + RE.Nota4) / 4 as 'Media',
		(FR.Dia1 + FR.Dia2 + FR.Dia3 + FR.Dia4) / 4 * 100 as 'Porcentagem',
		IIF(((RE.Nota1 + RE.Nota2 + RE.Nota3 + RE.Nota4) / 4) >= 7 and (FR.Dia1 + FR.Dia2 + FR.Dia3 + FR.Dia4) / 4 * 100 >= 75,'Aprovado','Reprovado') 
		as 'Situação'
	from Turmas TU
	inner join Alunos AL on TU.Id = AL.Turma
	inner join Registros RE on AL.Id = RE.Aluno
	inner join Frequencias FR on AL.Id = FR.Aluno