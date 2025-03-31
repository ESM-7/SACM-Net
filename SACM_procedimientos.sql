use CruzRojaPractica

CREATE TABLE Cita (
IdCita INT PRIMARY KEY IDENTITY(1,1),
TipoDeCita VARCHAR(40) NOT NULL,
Edad INT NOT NULL,
Nombre VARCHAR (50) NOT NULL,
ApellidoPaterno VARCHAR(50) NOT NULL,
ApellidoMaterno VARCHAR (50) NOT NULL,
NumeroTelefono VARCHAR(10) NOT NULL,
Sintoma VARCHAR (300) NOT NULL,
TieneEnfermedadesPrevias VARCHAR (300),
ConsumeMedicamento VARCHAR (300),
Alergias VARCHAR (300)
)

SELECT * FROM DiaSolicitados
SELECT * FROM Cita

CREATE TABLE DiaSolicitados(
Fecha VARCHAR (100),
Hora VARCHAR (15),
IdCita INT,
    CONSTRAINT FK_DiaSolicitados_Cita FOREIGN KEY (IdCita) REFERENCES Cita(IdCita)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

ALTER TABLE DiaSolicitados
ALTER COLUMN Hora TIME


------------------
CREATE PROCEDURE sp_MostrarInformacionCita
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        C.IdCita AS 'ID de Cita',
        C.TipoDeCita AS 'Departamento',
        C.Edad AS 'Edad',
        C.Nombre AS 'Nombre(s)',
        C.ApellidoPaterno AS 'Primer Apellido',
        C.ApellidoMaterno AS 'Segundo Apellido',
		C.NumeroTelefono AS 'Numero Telefono',
        C.Sintoma AS 'Sintomas',
        C.TieneEnfermedadesPrevias AS 'Enfermedades Previas',
        C.ConsumeMedicamento AS '¿Consume Medicamento?',
        C.Alergias AS 'Alergias',
        DS.Fecha AS 'Fecha de Cita',
        DS.Hora AS 'Hora de Cita'
    FROM
        Cita C
    INNER JOIN
        DiaSolicitados DS ON C.IdCita = DS.IdCita;
END;
--------------------------

alter PROCEDURE sp_InsertarCitaFechaHora
    @TipoDeCita VARCHAR(40),
    @Edad INT,
    @Nombre VARCHAR(50),
    @ApellidoPaterno VARCHAR(50),
    @ApellidoMaterno VARCHAR(50),
	@NumeroTelefono VARCHAR(10),
    @Sintoma VARCHAR(MAX),
    @TieneEnfermedadesPrevias VARCHAR(MAX),
    @ConsumeMedicamento VARCHAR(500),
    @Alergias VARCHAR(300),
    @Fecha VARCHAR(100),
	@Hora time
   -- @Hora VARCHAR(15)
AS
BEGIN
    DECLARE @NuevaIdCita INT;

    -- Insertar en la tabla Cita
    INSERT INTO Cita (TipoDeCita, Edad, Nombre, ApellidoPaterno, ApellidoMaterno, NumeroTelefono, Sintoma,
                      TieneEnfermedadesPrevias, ConsumeMedicamento, Alergias)
    VALUES (@TipoDeCita, @Edad, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @NumeroTelefono, @Sintoma,
            @TieneEnfermedadesPrevias, @ConsumeMedicamento, @Alergias);

    -- Obtener la nueva IdCita generada automáticamente. Para hacer uso de la ya creada IdCita
    SET @NuevaIdCita = SCOPE_IDENTITY();

    -- Insertar en la tabla DiaSolicitados
    INSERT INTO DiaSolicitados (Fecha, Hora, IdCita)
    VALUES (@Fecha, @Hora, @NuevaIdCita);
END;


-------------------
alter procedure sp_EliminarRegistro
@idregistro int 
as
begin
 delete Cita where IdCita = @idregistro
 end 

 ----------------------------
 alter PROCEDURE sp_MostrarInformacionCita
@fechaActual datetime
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
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


------------------------
alter procedure sp_MostrarRegistrosDepar
@tipoDepartamento varchar(30),
@fechaRegistro datetime
as 
begin
	select TipoDeCita, Nombre, NumeroTelefono, Fecha  
	from Cita c with(nolock) 
	inner join DiaSolicitados ds with(nolock) 
	on c.IdCita = ds.IdCita
	where convert (varchar, ds.Fecha, 23) = convert (varchar, @fechaRegistro, 23)
	and c.TipoDeCita = @tipoDepartamento
end 

select * from sp_MostrarRegistrosDepar
---------------------------------
create table Cat_horaDepartamento (
	departamento varchar(30),
	horadepartamento varchar(10) 
)

----------------------------------
CREATE PROCEDURE sp_CatDepartamento
@fecha datetime,
@departamento varchar(30)
AS
BEGIN
	SELECT cd.horaDepartamento
	FROM Cat_horaDepartamento CD
	LEFT JOIN DiaSolicitados DS 
		ON CD.horadepartamento = DS.Hora
		and CONVERT(varchar, ds.fecha, 23) = CONVERT(varchar, @fecha, 23)
	WHERE DS.Hora IS NULL
	AND CD.departamento = @departamento
END
-------------------------
alter PROCEDURE sp_ImprimirRegistrosDepar
AS
BEGIN
    SELECT C.TipoDeCita, C.Nombre, C.NumeroTelefono, D.Fecha
    FROM Cita AS C
    JOIN DiaSolicitados AS D ON C.IdCita = D.IdCita
END
GO

select * from Cat_horaDepartamento

select * from DiaSolicitados