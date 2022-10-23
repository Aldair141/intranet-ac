use BD_IntranetAC
go

create table dbo.Socio
(
	SocioId int identity(1,1),
	SocioNombre varchar(100),
	SocioApellidoPaterno varchar(60),
	SocioApellidoMaterno varchar(60),
	SocioTipoDocumento int,
	SocioNumeroDocumento varchar(20),
	SocioFechaRegistro datetime
)
go

alter table dbo.Socio add constraint pk_socio primary key (SocioId)
go

create table dbo.MembresiaEstado
(
	MembresiaEstadoId int identity(1,1),
	MembresiaEstadoDescripcion varchar(60)
)
go

alter table dbo.MembresiaEstado add constraint pk_membresia_estado primary key (MembresiaEstadoId)
go

create table dbo.Membresia
(
	MembresiaId int identity(1,1),
	SocioId int,
	FechaRegistro datetime,
	FechaAlta datetime,
	FechaBaja datetime,
	MembresiaEstado int
)
go

alter table dbo.Membresia add constraint pk_membresia primary key (MembresiaId)
go

alter table dbo.Membresia add constraint fk_membresia_socio foreign key (SocioId) references dbo.Socio (SocioId)
go

alter table dbo.Membresia add constraint fk_membresia_estado foreign key (MembresiaEstado) references dbo.MembresiaEstado (MembresiaEstadoId)
go

create table dbo.Reserva
(
	ReservaId int identity(1,1),
	SocioId int,
	AreaId int,
	FechaRegistro datetime,
	EstadoReserva int
)
go

alter table dbo.Reserva add constraint pk_reserva primary key (ReservaId)
go

alter table dbo.Reserva add constraint fk_reserva_socio foreign key (SocioId) references dbo.Socio (SocioId)
go

create table dbo.AreaEstado
(
	AreaEstadoId int identity(1,1),
	AreaEstadoDescripcion varchar(80)
)
go

alter table dbo.AreaEstado add constraint pk_area_estado_id primary key (AreaEstadoId)
go

create table dbo.Area
(
	AreaId int identity(1,1),
	AreaDescripcion varchar(100),
	AreaLongitud varchar(6),
	UnidadLongitud varchar(6),
	AreaEstadoId int
)
go

alter table dbo.Area add constraint pk_area_id primary key (AreaId)
go

alter table dbo.Area add constraint pk_area_estado foreign key (AreaEstadoId) references dbo.AreaEstado (AreaEstadoId)
go