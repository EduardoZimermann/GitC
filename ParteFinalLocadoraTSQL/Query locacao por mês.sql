--Relatório de locação por mês
select
		month(lo.DatLoc) as 'Mês',
		count(ca.Id) as 'Locações'
	from Locacoes lo
	inner join Carros ca on lo.Carro = ca.Id
	group by month(lo.DatLoc)
	order by count(ca.Id) desc;