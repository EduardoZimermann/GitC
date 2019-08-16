select 'Carros' as 'Carros',
	SUM(Temp.Media) as 'Vendas',
	Temp.AnoVenda from (select
		Modelo,
		Ano,
		(SUM(Vendas) / COUNT(Vendas)) as 'Media',
		YEAR(DataVenda) as 'AnoVenda'
		from Carros
	where year(DataVenda) = 2017
	group by Modelo,Ano,YEAR(DataVenda)) Temp
	group by Temp.AnoVenda