--Trazer somente as marcas que Felipe cadastrou
select
		Nome
	from Marcas
	where UsuInc=1;
go
--Trazer somente as marcas que Giomar cadastrou
select
		Nome
	from Marcas
	where UsuInc=2;
go
--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select
		count(Id) as 'Quantidade de Marcas'
	from Marcas
	where UsuInc = 1
	order by count(Id) desc;
go
--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select
		count(Id) as 'Quantidade de Marcas'
	from Marcas
	where UsuInc = 2
	order by count(Id) asc;
go
--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram
select
		us.Usuario,
		count(ma.Id) as 'Quantidade de Marcas'
	from Marcas ma
	inner join Usuarios us on ma.UsuInc = us.Id
	where ma.UsuInc between 1 and 2
	group by us.Usuario;
go
--Trazer somente os carros que Felipe cadastrou
select
		Modelo
	from Carros
	where UsuInc = 1;
go
--Trazer somente os carros que Giomar cadastrou
select
		Modelo
	from Carros
	where UsuInc = 2;
go
--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select
		count(Id) as 'Quantidade de Carros'
	from Carros
	where UsuInc = 1
	order by count(Id) desc
go
--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select
		count(Id) as 'Quantidade de Carros'
	from Carros
	where UsuInc = 2
	order by count(Id) asc
go
--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select
		us.Usuario,
		count(ca.Id) as 'Quantidade de Carros'
	from Carros ca
	inner join Usuarios us on ca.UsuInc = us.Id
	where ca.UsuInc between 1 and 2
	group by us.Usuario;
go
--Trazer somente os carros das marcas que Felipe cadastrou
select
		ca.Modelo
	from Carros ca
	inner join Marcas ma on ca.Marca = ma.Id
	where ma.UsuInc = 1;
go
--Trazer somente os carros das marcas que Giomar cadastrou
select
		ca.Modelo
	from Carros ca
	inner join Marcas ma on ca.Marca = ma.Id
	where ma.UsuInc = 2;
go
--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select
		count(ca.Id) as 'Quantidade de Carros'
	from Carros ca
	inner join Marcas ma on ca.Marca = ma.Id
	where ma.UsuInc = 1
	order by count(ca.Id) desc;
go
--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select
		count(ca.Id) as 'Quantidade de Carros'
	from Carros ca
	inner join Marcas ma on ca.Marca = ma.Id
	where ma.UsuInc = 2
	order by count(ca.Id) asc;
go
--Trazer o valor total de vendas 2019 isolado
select
		sum(Valor * Quantidade) as 'Valor total'
	from Vendas
	where year(DatInc) = 2019;
go
--Trazer a quantidade total de vendas 2019 isolado
select
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas
	where year(DatInc) = 2019;
go
--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select
		year(DatInc) as 'Ano',
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas
	group by year(DatInc)
	order by sum(Valor * Quantidade) desc;
go
--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select
		year(DatInc) as 'Ano',
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas
	group by year(DatInc)
	order by sum(Quantidade) desc;
go
--Trazer o mês de cada ano que retornou a maior quantidade de vendas
	--	- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select
		month(DatInc) as 'Mês',
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas
	group by month(DatInc)
	order by sum(Quantidade) desc;
go
--Trazer o mês de cada ano que retornou o maior valor de vendas
	--	- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
select
		month(DatInc) as 'Mês',
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas
	group by month(DatInc)
	order by sum(Valor * Quantidade) desc;
go
--Trazer o valor total de vendas que Felipe realizou
select
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas
	where UsuInc = 1;
go
--Trazer o valor total de vendas que Giomar realizou
select
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas
	where UsuInc = 2;
go
--Trazer a quantidade total de vendas que Felipe realizou
select
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas
	where UsuInc = 1;
go
--Trazer a quantidade de vendas que Giomar realizou
select
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas
	where UsuInc = 2;
go
--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select
		us.Usuario,
		sum(ve.Quantidade) as 'Quantidade de Vendas'
	from Vendas ve
	inner join Usuarios us on ve.UsuInc = us.Id
	where ve.UsuInc between 1 and 2
	group by us.Usuario
	order by sum(ve.Quantidade) desc;
go
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select
		us.Usuario,
		sum(ve.Valor * ve.Quantidade) as 'Valor de Vendas'
	from Vendas ve
	inner join Usuarios us on ve.UsuInc = us.Id
	where ve.UsuInc between 1 and 2
	group by us.Usuario
	order by sum(ve.Valor * ve.Quantidade) desc;
go
--Trazer  a marca mais vendida de todos os anos
	--	- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select
		ma.Nome,
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas ve
	inner join Carros ca on ve.Carro = ca.Id
	inner join Marcas ma on ca.Marca = ma.Id
	group by ma.Nome
	order by sum(Quantidade) desc;
--Trazer o valor total da marca mais vendida de todos os anos
select
		ma.Nome,
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas ve
	inner join Carros ca on ve.Carro = ca.Id
	inner join Marcas ma on ca.Marca = ma.Id
	group by ma.Nome
	order by sum(Valor * Quantidade) desc;
go
--Trazer a quantidade do carro mais vendido de todos os anos
select
		ca.Modelo,
		sum(Quantidade) as 'Quantidade de Vendas'
	from Vendas ve
	inner join Carros ca on ve.Carro = ca.Id
	group by ca.Modelo
	order by sum(Quantidade) desc;
go
--Trazer o valor do carro mais vendido de todos os anos
select
		ca.Modelo,
		sum(Valor * Quantidade) as 'Valor de Vendas'
	from Vendas ve
	inner join Carros ca on ve.Carro = ca.Id
	group by ca.Modelo
	order by sum(Valor * Quantidade) desc;

--FIM =)