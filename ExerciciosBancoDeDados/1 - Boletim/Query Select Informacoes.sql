
select
		AL.Nome,
		AL.Idade,
		TU.Serie as 'Turma',
		SUM(RE.Nota) / 4 as 'Media',
		SUM(CASE RE.Presente WHEN 1 THEN 1 ELSE 0 END) * 100 / COUNT(RE.Presente) as 'Frequencia',
		IIF((SUM(RE.Nota) / COUNT(RE.Nota)) >= 7 and (SUM(CASE RE.Presente WHEN 1 THEN 1 ELSE 0 END) * 100 / COUNT(RE.Presente)) >= 75,'Aprovado','Reprovado')
		as 'Situação'
	from Turmas TU
	inner join Alunos AL on TU.Id = AL.Turma
	inner join Registros RE on AL.Id = RE.Aluno
	group by AL.Nome,AL.Idade,TU.Serie