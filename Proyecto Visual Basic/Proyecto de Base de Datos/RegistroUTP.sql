--En caso de ya tener la base de datos UniversidadUTP en su SQL, ejecutar estas líneas para eliminar sus tablas,
--de lo contrario, no las ejecute.
DROP TABLE Imparte
DROP TABLE Codigo_Curso
DROP TABLE Cursa
DROP TABLE Telefono_est
DROP TABLE Telefono_fac
DROP TABLE Compone
DROP TABLE Docente
DROP TABLE Asignatura
DROP TABLE Grupo
DROP TABLE Carrera
DROP TABLE Estudiante
DROP TABLE Facultad
---------------------------

--Ejecutar esta línea si aún no tiene la base de datos UniversidadUTP creada en su SQL
CREATE DATABASE UniversidadUTP
-------------------------------


CREATE TABLE Facultad
(
	codFacultad varchar(4)
		CONSTRAINT Facultad_codFacultad_pk primary key
		CHECK (codFacultad IN ('FCT', 'FIC', 'FIE', 'FII', 'FIM', 'FISC')), 
	fac_correo nvarchar(15) not null,
	horario_atencion nvarchar(40) not null,
	num_edificio int not null,
	num_piso tinyint not null
)


CREATE TABLE Estudiante
(
	est_cedula nvarchar(15)
		CONSTRAINT Estudiante_est_cedula_pk primary key,
	est_nombre nvarchar(20) not null,
	est_apellido nvarchar(20) not null,
	est_correo nvarchar(50) not null,
	contraseña nvarchar(10) not null,
	nacionalidad nvarchar(20) not null,
	direccion nvarchar(100),
	año_cursado tinyint not null,
	indice decimal(3, 2) not null,
	matriculado char(2) not null,
	facCodigo varchar(4) not null
		CONSTRAINT Facultad_facCodigo_fk foreign key
		REFERENCES Facultad(codFacultad)
)


CREATE TABLE Grupo
(
	grupo char(6)
		CONSTRAINT Grupo_grupo_pk primary key,
	nivel char(1) not null,
	turno varchar(10) not null
		CHECK (turno IN ('matutino', 'vespertino'))
)


CREATE TABLE Carrera
(
	cod_planEstudio nvarchar(100)
		CONSTRAINT Carrera_cod_planEstudio_pk primary key,
	duracion varchar(25) not null,
	costo decimal(5,2) not null,
	turno varchar(20) not null
		CHECK (turno IN ('diurno', 'nocturno', 'diurno/nocturno'))
)


CREATE TABLE Asignatura
(
	codAsig char(4)
		CONSTRAINT Asignatura_codAsig_pk primary key,
	asig_nombre nvarchar(50) not null,
	fundamental char(2) not null,
		CHECK (fundamental IN ('*', '')),
	cant_creditos tinyint not null
)


CREATE TABLE Docente
(
	doc_cedula nvarchar(15)
		CONSTRAINT Docente_doc_cedula_pk primary key,
	doc_nombre nvarchar(20) not null,
	doc_apellido nvarchar(20) not null,
	doc_correo nvarchar(50) not null,
	tipoD nvarchar(25) not null,
		CHECK (tipoD IN ('REGULAR AUXILIAR', 'REGULAR AGREGADO', 'REGULAR TITULAR', 
		'ESPECIAL EVENTUAL', 'ESPECIAL EXTRAORDINARIO', 'ESPECIAL VISITANTE', 
		'INSTRUCTOR A-1', 'INSTRUCTOR A-2', 'INSTRUCTOR A-3', 'INSTRUCTOR B-1', 'INSTRUCTOR B-2', 'INSTRUCTOR B-3')),
	tipo_horario varchar(8) not null
		CHECK (tipo_horario IN ('COMPLETO', 'PARCIAL'))
)


CREATE TABLE Compone
(
	CONSTRAINT Compone_asigCodigo_planEstudio_Cod_pk primary key(asigCodigo, planEstudio_Cod),
	asigCodigo char(4)
		CONSTRAINT Compone_asigCodigo_fk foreign key
		REFERENCES Asignatura(codAsig),
	planEstudio_Cod nvarchar(100)
		CONSTRAINT Compone_planEstudio_Cod_fk foreign key
		REFERENCES Carrera(cod_planEstudio)
)


CREATE TABLE Imparte
(
	CONSTRAINT Imparte_asigCodigo_cedula_doc_pk primary key(asigCodigo, cedula_doc),
	asigCodigo char(4)
		CONSTRAINT Imparte_asigCodigo_fk foreign key
		REFERENCES Asignatura(codAsig),
	cedula_doc nvarchar(15)
		CONSTRAINT Imparte_cedula_doc_fk foreign key
		REFERENCES Docente(doc_cedula)
)


CREATE TABLE Telefono_est
(
	est_telefono nvarchar(15),
	cedula_est nvarchar(15)
		CONSTRAINT Telefono_est_cedula_est_fk foreign key
		REFERENCES Estudiante(est_cedula),
	CONSTRAINT Telefono_est_cedula_est_est_telefono_pk primary key(cedula_est, est_telefono)		
)


CREATE TABLE Telefono_fac
(
	fac_telefono nvarchar(8),
	fac_Codigo varchar(4)
		CONSTRAINT Telefono_fac_fac_Codigo_fk foreign key
		REFERENCES Facultad(codFacultad),
	CONSTRAINT Telefono_fac_fac_telefono_fac_Codigo_pk primary key(fac_telefono, fac_Codigo)		
)


CREATE TABLE Cursa
(
	CONSTRAINT Cursa_cedula_est_grup_asigCodigo_pk primary key(cedula_est, grup, asigCodigo),
	cedula_est nvarchar(15)
		CONSTRAINT Cursa_cedula_est_fk foreign key
		REFERENCES Estudiante(est_cedula),
	grup char(6)
		CONSTRAINT Cursa_grup_fk foreign key
		REFERENCES Grupo(grupo),
	asigCodigo char(4)
		CONSTRAINT Cursa_asigCodigo_fk foreign key
		REFERENCES Asignatura(codAsig)
)


CREATE TABLE Codigo_Curso
(
	CONSTRAINT Codigo_Curso_grup_asigCodigo_pk primary key(grup, asigCodigo),
	grup char(6)
		CONSTRAINT Codigo_Curso_grup_fk foreign key
		REFERENCES Grupo(grupo),
	asigCodigo char(4)
		CONSTRAINT Codigo_Curso_asigCodigo_fk foreign key
		REFERENCES Asignatura(codAsig),
	codHora char(4) not null
)