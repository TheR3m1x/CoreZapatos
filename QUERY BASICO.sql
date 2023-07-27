create database X;

use X;

CREATE TABLE [dbo].[Usuarios] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
    [username]          VARCHAR (50)  NOT NULL,
    [password]          VARCHAR (255) NOT NULL,
    [rol]               INT           NOT NULL,
    [genero]            CHAR (1)      NOT NULL,
    [nombreUser]        NVARCHAR (50) NOT NULL,
    [apellidoUser]      NVARCHAR (50) NOT NULL,
    [emailUser]         NVARCHAR (50) NOT NULL,
    [cedulaUser]        NUMERIC (11)  NOT NULL,
    [fechaCreacion]     DATETIME      DEFAULT (getdate()) NULL,
    [fechaUltimaAccion] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC),
    FOREIGN KEY ([rol]) REFERENCES [dbo].[Roles] ([id])
);

CREATE TABLE [dbo].[Roles] (
    [id]           INT          IDENTITY (1, 1) NOT NULL,
    [rol]          VARCHAR (30) NULL,
    [nivelPermiso] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
CREATE TABLE [dbo].[Productos] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [descripcion] VARCHAR (50)  NOT NULL,
    [precio]      MONEY         NOT NULL,
    [cantidad]    INT           NOT NULL,
    [proveedor]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Generos] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [nombreGenero] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
CREATE TABLE [dbo].[Facturas] (
    [Id_Factura]     INT             IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]     INT             NOT NULL,
    [Fecha]          DATE            NOT NULL,
    [Total]          DECIMAL (10, 2) NOT NULL,
    [ProductoID]     INT             NOT NULL,
    [Descripcion]    VARCHAR (50)    NOT NULL,
    [PrecioUnitario] DECIMAL (10, 2) NOT NULL,
    [Cantidad]       INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Factura] ASC),
    FOREIGN KEY ([ID_Cliente]) REFERENCES [dbo].[Clientes] ([ID_Cliente]),
    FOREIGN KEY ([ProductoID]) REFERENCES [dbo].[Productos] ([id])
);

CREATE TABLE [dbo].[CuentasPorCobrar] (
    [Id_CuentasPorCobrar] INT             IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]          INT             NULL,
    [FechaEmision]        DATE            NULL,
    [ProductoID]          INT             NULL,
    [Descripcion]         VARCHAR (50)    NULL,
    [MontoTotal]          DECIMAL (10, 2) NULL,
    [MontoPagado]         DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id_CuentasPorCobrar] ASC)
);
CREATE TABLE [dbo].[Cotizaciones] (
    [Id_Cotizaciones] INT             IDENTITY (1, 1) NOT NULL,
    [ID_Cliente]      INT             NOT NULL,
    [Fecha]           DATE            NOT NULL,
    [ProductoID]      INT             NOT NULL,
    [Descripcion]     VARCHAR (200)   NOT NULL,
    [PrecioUnitario]  DECIMAL (10, 2) NOT NULL,
    [Cantidad]        INT             NOT NULL,
    [ITBIS]           DECIMAL (10, 2) NOT NULL,
    [Descuento]       DECIMAL (10, 2) NOT NULL,
    [Total]           DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Cotizaciones] ASC)
);

CREATE TABLE [dbo].[Clientes] (
    [ID_Cliente] INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]     VARCHAR (100) NOT NULL,
    [Apellido]   VARCHAR (100) NOT NULL,
    [Email]      VARCHAR (100) NOT NULL,
    [Telefono]   VARCHAR (20)  NOT NULL,
    [Direccion]  VARCHAR (MAX) NOT NULL,
    [Cedula]     NCHAR (11)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Cliente] ASC)
);








insert into Roles(rol, nivelPermiso) values ('Administrador', 1);
insert into Roles(rol, nivelPermiso) values ('Mantenimiento', 2);
insert into Roles(rol, nivelPermiso) values ('Usuarios', 3);
insert into Roles(rol, nivelPermiso) values ('Consultas', 4);

insert into Usuarios(username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser) Values ('admin', 'admin', 1, 'M', 'Juan', 'Encarnacion', 'juan.alejandro.e1@gmail.com', '40211405168');