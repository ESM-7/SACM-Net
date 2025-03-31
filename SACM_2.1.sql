-- PROCEDIMIENTO MOSTRAR REGISTROS EN BASE A LOS DEPARTAMENTOS Y FECHAS
use CruzRojaPractica
alter procedure sp_MostrarRegistrosDepar
@tipoDepartamento varchar(30),
@fechaRegistro datetime
as 
begin
	select TipoDeCita, Nombre, NumeroTelefono, Fecha, Confirmacion  
	from Cita c with(nolock) 
	inner join DiaSolicitados ds with(nolock) 
	on c.IdCita = ds.IdCita
	where convert (varchar, ds.Fecha, 23) = convert (varchar, @fechaRegistro, 23)
	and c.TipoDeCita = @tipoDepartamento
	
end 

CREATE TABLE DiaSolicitados(
Fecha VARCHAR (100),
Hora VARCHAR (15),
IdCita INT,
    CONSTRAINT FK_DiaSolicitados_Cita FOREIGN KEY (IdCita) REFERENCES Cita(IdCita)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

--alter table DiaSolicitados 
--add  Confirmacion Varchar(20)


ALTER TABLE DiaSolicitados
ALTER COLUMN Hora VARCHAR(15)

select * from DiaSolicitados

alter PROCEDURE sp_MostrarInformacionCita
@fechaActual datetime
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
		DS.Confirmacion  as 'Confirmacion',
        C.IdCita AS 'ID de Cita',
        C.TipoDeCita AS 'Departamento',
        C.Edad AS 'Edad',
        C.Nombre AS 'Nombre(s)',
        C.ApellidoPaterno AS 'Primer Apellido',
        C.ApellidoMaterno AS 'Segundo Apellido',
        C.Sintoma AS 'Sintomas',
        C.TieneEnfermedadesPrevias AS 'Enfermedades Previas',
        C.ConsumeMedicamento AS '¿Consume Medicamento?',
        C.Alergias AS 'Alergias',
        DS.Fecha AS 'Fecha de Cita',
        DS.Hora AS 'Hora de Cita'
    FROM
        Cita C
    INNER JOIN
        DiaSolicitados DS ON C.IdCita = DS.IdCita
		where CONVERT(varchar,@fechaActual,23) = CONVERT(varchar,DS.Fecha,23)
END;


alter procedure sp_EliminarRegistro
@idregistro int 
as
begin
update DiaSolicitados
set Confirmacion = 'Cancelada'
where IdCita = @idregistro 
 --delete Cita where IdCita = @idregistro
 end 


 alter PROCEDURE sp_CatDepartamento
@fecha datetime,
@departamento varchar(30)
AS
BEGIN
	SELECT cd.horaDepartamento
	FROM Cat_horaDepartamento CD
	LEFT JOIN DiaSolicitados DS 
		ON CD.horadepartamento = DS.Hora
			and isnull(Confirmacion,'')  != 'Cancelada' 
		and CONVERT(varchar, ds.fecha, 23) = CONVERT(varchar, @fecha, 23)
	WHERE DS.Hora IS NULL
	AND CD.departamento = @departamento

END

select * from Cat_horaDepartamento
select * from DiaSolicitados where isnull(Confirmacion,'')  != 'Cancelada' 


exec sp_CatDepartamento '2024-05-21 00:00:00.000', 'Medicina General'