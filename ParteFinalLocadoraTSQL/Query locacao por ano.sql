--Relatório de locação anual
select
		Year(lo.DatLoc) as 'Ano',
		count(ca.Id) as 'Locações'
	from Locacoes lo
	inner join Carros ca on lo.Carro = ca.Id
	group by Year(lo.DatLoc)
	order by count(ca.Id) desc;