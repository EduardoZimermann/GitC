select *
	from Biblioteca BL
	inner join Livros LV on BL.Id = LV.Biblioteca
select *
	from Biblioteca BL
	left join Livros LV on BL.Id = LV.Biblioteca