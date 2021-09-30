create proc BuscarPersonaNombre
	@FirstName nvarchar(50)
as
select * from Person where FirstName like '%'+@FirstName+'%';

create proc BuscarCursoTitulo
	@Title nvarchar(100)
as
select * from Course where Title like '%'+@Title+'%';