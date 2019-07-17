select
		Aluno,
		Idade,
		IIF(Ativo = 1,'Ativo','Inativo') as 'Status'
	from AulaCSharp
where ID in
	(select ID 
	from AulaCSharp 
	where Idade > 22)
order by ID desc