use lc_tpi_cine

/* Aqui se encuentran los SP creados para poder desarrollar la parte 3 del TP de Laboratorio */

create procedure SP_CONSULTAR_EMPLEADOS
as
begin
    select * from empleados order by 2
end

create procedure SP_CONSULTAR_CLIENTES
as
begin
    select * from clientes order by 2
end

create procedure SP_CONSULTAR_FORMAS_PAGO
as
begin
    select * from forma_pago order by 2
end

--SP CONSULTAR COMPROBANTES CON FILTROS--
create procedure [dbo].[SP_CONSULTAR_COMPROBANTES_FILTRADOS]
@id_comprobante int=null,
@id_cliente int=null,
@id_forma_pago int=null,
@id_empleado int=null,
@cant_entradas_1 int=null,
@cant_entradas_2 int=null,
@importe_Desde decimal(10,2)=null,
@importe_hasta decimal(10,2)=null
as
select c.*,cl.nombre+' '+cl.apellido Cliente,e.nombre+' '+e.apellido Empleado,f.descripcion Forma_Pago,
pre_unitario*cant_entradas Importe
from comprobantes c
join clientes cl on cl.id_cliente=c.id_cliente
join empleados e on e.id_empleado=c.id_empleado
join forma_pago f on f.id_forma_pago=c.id_forma_pago
join tickets t on t.id_comprobante=c.id_comprobante
where (@id_comprobante is null or c.id_comprobante=@id_comprobante)
and (@id_cliente is null or c.id_cliente=@id_cliente)
and (@id_forma_pago is null or c.id_forma_pago=@id_forma_pago)
and (@id_empleado is null or c.id_empleado=@id_empleado)
and (@cant_entradas_1 is null or @cant_entradas_2 is null 
or cant_entradas between @cant_entradas_1 and @cant_entradas_2)
and (@importe_Desde is null or @importe_hasta is null
or (pre_unitario*cant_entradas) between @importe_Desde and @importe_hasta)

-- SP CONSULTAR LO QUE RECAUDO CADA PELICULA, LA CANTIDAD DE ENTRADAS QUE VENDIO Y LA CANTIDAD DE FUNCIONES QUE TUVO
-- ENTRE DOS FECHAS PASADAS POR PARAMETRO O INGRESANDO EL NOMBRE DE PELICULA

create PROCEDURE [dbo].[SP_CONSULTAR_PELICULAS]
    @fecha_desde Datetime,
    @fecha_hasta Datetime
AS
BEGIN
    SELECT  p.descripcion as 'nombre',
		sum (c.cant_entradas*t.pre_unitario) as 'total',
		sum(c.cant_entradas)as'cantidad',
		count(f.id_funcion) as'funciones'
    FROM peliculas p
    join funciones f on f.id_pelicula = p.id_pelicula
    join butacas b on b.id_funcion = f.id_funcion
    join tickets t on t.id_butacas = b.id_butaca
    join comprobantes c on c.id_comprobante = t.id_comprobante
    WHERE (@fecha_desde is null OR f.fecha >= @fecha_desde)
    AND (@fecha_hasta is null OR f.fecha <= @fecha_hasta)
    group by p.descripcion
END

-- 

create PROCEDURE [dbo].[SP_CONSULTAR_RESERVAS]
	@nombreReserva varchar(50)=null,
	@fechaReserva datetime=null
AS
BEGIN
	SELECT r.nombre_reserva 'Nombre de la reserva',
		c.apellido+' '+c.nombre 'Cliente',
		r.fecha_reserva 'Fecha de la reserva',
		p.descripcion 'Pelicula reservada',
		f.fecha 'Fecha de la pelicula',
		f.hora 'Hora de la pelicula'
	FROM reservas r
	join clientes c on c.id_cliente = r.id_cliente
	join butacas b on b.id_butaca = r.id_butaca
	join funciones f on f.id_funcion = b.id_funcion
	join peliculas p on p.id_pelicula = f.id_pelicula
	where (@fechaReserva = r.fecha_reserva) AND (r.nombre_reserva LIKE '%' + @nombreReserva + '%') 
END

--Se quiere saber cuántas personas vieron a un determinado director y cuánto dinero generó en una fecha menor o igual a la ingresada por el usuario.

create procedure [dbo].[SP_CONSULTAR_DIR_GEN]
@fecha_menor datetime,
@director int,
@genero int
AS
BEGIN
SELECT dir.nombre as nombre, dir.apellido as apellido, sum(cant_entradas) as 'personas', sum(cant_entradas * pre_unitario) as 'recaudacion'
FROM peliculas p 
JOIN tipos_pelicula tip on tip.id_tipo_pelicula = p.id_tipo_pelicula
JOIN dialectos d on d.id_idioma = p.id_idioma
JOIN funciones f on f.id_pelicula = p.id_pelicula
JOIN butacas b on b.id_funcion = f.id_funcion
JOIN tickets tick on tick.id_butacas = b.id_butaca
JOIN comprobantes com on com.id_comprobante = tick.id_comprobante
JOIN directores dir on dir.id_director = p.id_director
WHERE (@fecha_menor is null OR f.fecha <= @fecha_menor)
    AND (@director is null OR dir.id_director = @director)
    AND (@genero is null OR tip.id_tipo_pelicula = @genero)
GROUP BY dir.nombre, dir.apellido
end

create procedure SP_CONSULTAR_TIPOS_PELICULAS
as
begin
    select * from tipos_pelicula order by 2
end

create procedure SP_CONSULTAR_DIRECTORES
as
begin
    select * from directores order by 2
end