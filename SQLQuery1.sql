IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Pacientes1')
BEGIN
    CREATE DATABASE [Pacientes1];
END
GO


USE [Pacientes1];
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PacientesPersonas]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[PacientesPersonas] (
        [id_paciente]        INT           IDENTITY (1, 1) NOT NULL,
        [nombre]             VARCHAR (50)  NOT NULL,
        [apellido]           VARCHAR (50)  NULL,
        [fecha_nacimiento]   DATE          NULL,
        [genero]             VARCHAR (20)  NULL,
        [telefono]           VARCHAR (20)  NULL,
        [correo_electronico] VARCHAR (100) NULL,
        [direccion]          VARCHAR (200) NULL,
        [fecha_registro]     DATETIME      DEFAULT GETDATE(),
        [observaciones]      VARCHAR (500) NULL,
        PRIMARY KEY CLUSTERED ([id_paciente] ASC)
    );
    PRINT '¡Tabla creada con éxito en GestionPacientes!';
END
ELSE
BEGIN
    PRINT 'La tabla ya existía en esta base de datos.';
END
GO