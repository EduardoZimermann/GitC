select
		Tipo,
		SUM(Vendas) as 'Vendas',
		MONTH(DataVenda) as 'Mês'
	from Dogs
	group by Tipo,MONTH(DataVenda)
	order by SUM(Vendas) desc