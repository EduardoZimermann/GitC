--Relatório do Carro que mais foi alocado anual
select
		year(lo.DatLoc) as 'Ano Locação',
		ca.Marca,
		ca.Modelo,
		ca.Ano,
		count(ca.Id) as 'Locacoes'
	from Locacoes lo
	inner join Carros ca on lo.Carro = ca.Id
	where year(lo.DatLoc) = 2017 --Ano é definido aqui (entre 2017 - 2019)
	group by ca.Marca,ca.Modelo,ca.Ano,year(lo.DatLoc)
	order by count(ca.Id) desc