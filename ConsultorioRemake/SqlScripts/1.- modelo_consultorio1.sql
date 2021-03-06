-- Generado por Oracle SQL Developer Data Modeler 4.1.5.907
--   en:        2017-09-27 00:44:09 GMT-04:00
--   sitio:      Oracle Database 11g
--   tipo:      Oracle Database 11g

SET QUOTED_IDENTIFIER ON

go


/* Create Empresas database.                                                                  */
use master  

go

create database "Consultorios"  

go

use "Consultorios"  

go

CREATE TABLE Consultorio
  (
    id_consultorio int NOT NULL PRIMARY KEY,
    rut_consultorio int,
    dv char(1),
    id_comuna INT ,
    nombre NVARCHAR(30)
  );

CREATE TABLE Alergia
  (
    id_alergia INT NOT NULL PRIMARY KEY,
    nombre NVARCHAR (30) NOT NULL
  ) ;

CREATE TABLE Alergia_Paciente
(
  id_alergia_paciente INT NOT NULL PRIMARY KEY,
  id_alergia INT NOT NULL,
  id_paciente INT NOT NULL
);

CREATE TABLE Provincia
  (
    id_provincia INT NOT NULL ,
    nom_provincia NVARCHAR (30) ,
    id_region INT NOT NULL
  ) ;
ALTER TABLE Provincia ADD CONSTRAINT Provincia_PK PRIMARY KEY ( id_provincia ) ;



CREATE TABLE Comuna
  (
    id_comuna INT NOT NULL ,
    nom_com NVARCHAR (30) ,
    id_provincia INT NOT NULL
  ) ;
ALTER TABLE Comuna ADD CONSTRAINT Comuna_PK PRIMARY KEY ( id_comuna ) ;


CREATE TABLE Control_Acceso
  (
    id_control_acceso INT NOT NULL PRIMARY KEY,
    usuario_login NVARCHAR (30)  ,
    contrasena NVARCHAR (30) ,
    id_tipo_usuario INT ,
    id_usuario INT ,
    activo INT
  ) ;



CREATE TABLE Enfermera
  (
    id_enfermera       INT NOT NULL PRIMARY KEY,
    id_usuario         INT  ,
    id_jornada_laboral INT ,
  ) ;


CREATE TABLE Especialidad
  (
    id_especialidad INT NOT NULL ,
    nom_especialidad NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Especialidad ADD CONSTRAINT Especialidad_PK PRIMARY KEY ( id_especialidad ) ;


CREATE TABLE Ficha_Paciente
  (
    id_ficha_paciente INT NOT NULL PRIMARY KEY,
    fecha             DATE,
    id_consultorio    INT  ,   
    id_Medico         INT  ,
    id_enfermera      INT ,
    id_paciente       INT ,
    peso              INT ,
    estatura          INT  ,
    imc               NVARCHAR(30)  ,
    temperatura       INT ,
    sistonica         INT ,
    pulsacion         INT ,
    diastolica        INT ,
    motivos NVARCHAR(300),
    diagnostico NVARCHAR(500)
  ) ;


CREATE TABLE Genero
  (
    id_genero INT NOT NULL ,
    nom_genero NVARCHAR (30)
  ) ;
ALTER TABLE Genero ADD CONSTRAINT Genero_PK PRIMARY KEY ( id_genero ) ;


CREATE TABLE Grupo_sanguineo
  (
    id_grupo_sanguineo INT NOT NULL ,
    nombre NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Grupo_sanguineo ADD CONSTRAINT Grupo_sanguineo_PK PRIMARY KEY ( id_grupo_sanguineo ) ;


CREATE TABLE Jornada_laboral
  (
    id_jornada_laboral INT NOT NULL ,
    lunes              INT ,
    martes             INT  ,
    miercoles          INT ,
    jueves             INT  ,
    viernes            INT ,
    sabado             INT  ,
    domingo            INT ,
    id_sector          INT ,
    glosa              NVARCHAR(30) 
  	) ;
ALTER TABLE Jornada_laboral ADD CONSTRAINT Jornada_laboral_PK PRIMARY KEY ( id_jornada_laboral ) ;


CREATE TABLE Licencia_Medica
  (
    id_licencia_medica INT NOT NULL PRIMARY KEY,
    numero_de_dias     INT  ,
    motivos NVARCHAR (30)  ,
    id_ficha_paciente INT 
  ) ;


CREATE TABLE Medicamentos
  (
    id_medicamentos INT NOT NULL PRIMARY KEY,
    principio_activo NVARCHAR(30),
    producto_referencia NVARCHAR(30),
    nombre_producto NVARCHAR (60),
    codigo_registro NVARCHAR(30),
    glosa NVARCHAR(60)
  ) ;


CREATE TABLE Medico
  (
    id_Medico  INT PRIMARY KEY,
    rut_medico INT  ,
    dv_medico CHAR(1)  ,
    id_usuario         INT  ,
    id_especialidad    INT  ,
    id_jornada_laboral INT 
  ) ;

CREATE TABLE Administrador
  (
    id_administrador  INT NOT NULL PRIMARY KEY, 
    id_usuario INT 
  ) ;

CREATE TABLE Nacionalidad
  (
    id_nacionalidad INT  NOT NULL ,
    nom_nacio NVARCHAR (30)
  ) ;
ALTER TABLE Nacionalidad ADD CONSTRAINT Nacionalidad_PK PRIMARY KEY ( id_nacionalidad ) ;


CREATE TABLE Paciente
  (
    id_paciente        INT NOT NULL PRIMARY KEY,
    id_usuario         INT  ,
    id_grupo_sanguineo INT  ,
    id_rh              INT  ,
    id_sector          INT 
  ) ;

CREATE TABLE Pais
  (
    id_pais INT NOT NULL ,
    nom_pais NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Pais ADD CONSTRAINT Pais_PK PRIMARY KEY ( id_pais ) ;


CREATE TABLE Receta_Medica
  (
    id_Receta_Medica INT NOT NULL PRIMARY KEY,
    fecha            DATE ,
    cantidad         INT ,
    hora             INT  ,
    dia              INT  ,
    glosa NVARCHAR (300)  ,
    id_ficha_paciente INT ,
    id_medicamentos   INT 
  ) ;

CREATE TABLE Region
  (
    id_region INT NOT NULL ,
    nom_region NVARCHAR (30) NOT NULL ,
    id_pais INT NOT NULL
  ) ;
ALTER TABLE Region ADD CONSTRAINT Region_PK PRIMARY KEY ( id_region ) ;


CREATE TABLE Rh_sanguineo
  (
    id_rh INT NOT NULL ,
    nombre NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Rh_sanguineo ADD CONSTRAINT Rh_sanguineo_PK PRIMARY KEY ( id_rh ) ;


CREATE TABLE Secretaria
  (
    id_secretaria      INT NOT NULL  PRIMARY KEY,
    id_usuario         INT  ,
    id_jornada_laboral INT 
  ) ;


CREATE TABLE Sector
  (
    id_sector INT NOT NULL ,
    nombre NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Sector ADD CONSTRAINT Sector_PK PRIMARY KEY ( id_sector ) ;


CREATE TABLE Tipo_Usuario
  (
    id_tipo_usuario INT NOT NULL ,
    nom_tipo_usuario NVARCHAR (30)
  ) ;
ALTER TABLE Tipo_Usuario ADD CONSTRAINT Tipo_Usuario_PK PRIMARY KEY ( id_tipo_usuario ) ;


CREATE TABLE Usuario
  (
    id_usuario  INT NOT NULL ,
    rut_usuario INT  ,
    dv_usuario CHAR(1)  ,
    foto NVARCHAR(30) ,
    pnombre NVARCHAR (30)  ,
    snombre NVARCHAR (30) ,
    appaterno NVARCHAR (30)  ,
    apmaterno NVARCHAR (30) ,
    fecha_nacimiento DATE ,
    direccion NVARCHAR (30) ,
    fono1             INT ,
    fono2             INT ,   
    id_comuna         INT  ,
    id_nacionalidad   INT  ,
    id_genero         INT  ,
    activo            INT 
  ) ;
ALTER TABLE Usuario ADD CONSTRAINT Usuario_PK PRIMARY KEY ( id_usuario ) ;

CREATE TABLE Tipo_Desvinculado
(
  id_tipo_desvin INT NOT NULL,
  nombre         NVARCHAR(30),
  glosa           NVARCHAR(30)
);
ALTER TABLE Tipo_Desvinculado ADD CONSTRAINT Tipo_Desvincu_PK PRIMARY KEY ( id_tipo_desvin ) ;

CREATE TABLE Desvinculado
(
  id_desvinculado INT PRIMARY KEY,
  id_usuario      INT ,
  fecha           DATE,
  id_tipo_desvin  INT ,
  glosa           NVARCHAR(30)
);

ALTER TABLE Desvinculado ADD CONSTRAINT tipoDesc_Desvinculado_FK FOREIGN KEY ( id_tipo_desvin ) REFERENCES Tipo_Desvinculado (id_tipo_desvin);
ALTER TABLE Desvinculado ADD CONSTRAINT Usuario_Desvinculado_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Comuna ADD CONSTRAINT Comuna_Provincia_FK FOREIGN KEY ( id_provincia ) REFERENCES Provincia ( id_provincia ) ;

ALTER TABLE Provincia ADD CONSTRAINT Provincia_Region_FK FOREIGN KEY ( id_region ) REFERENCES Region ( id_region ) ;

ALTER TABLE Control_Acceso ADD CONSTRAINT Control_Acceso_Tipo_Usuario_FK FOREIGN KEY ( id_tipo_usuario ) REFERENCES Tipo_Usuario ( id_tipo_usuario ) ;

ALTER TABLE Control_Acceso ADD CONSTRAINT Control_Acceso_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Enfermera ADD CONSTRAINT Enfermera_Jornada_laboral_FK FOREIGN KEY ( id_jornada_laboral ) REFERENCES Jornada_laboral ( id_jornada_laboral ) ;

ALTER TABLE Enfermera ADD CONSTRAINT Enfermera_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Jornada_laboral ADD CONSTRAINT Jornada_laboral_Sector_FK FOREIGN KEY ( id_sector ) REFERENCES Sector ( id_sector ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Especialidad_FK FOREIGN KEY ( id_especialidad ) REFERENCES Especialidad ( id_especialidad ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Jornada_laboral_FK FOREIGN KEY ( id_jornada_laboral ) REFERENCES Jornada_laboral ( id_jornada_laboral ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Administrador ADD CONSTRAINT Admin_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Paciente ADD CONSTRAINT Paciente_Grupo_sanguineo_FK FOREIGN KEY ( id_grupo_sanguineo ) REFERENCES Grupo_sanguineo ( id_grupo_sanguineo ) ;

ALTER TABLE Paciente ADD CONSTRAINT Paciente_Rh_sanguineo_FK FOREIGN KEY ( id_rh ) REFERENCES Rh_sanguineo ( id_rh ) ;

ALTER TABLE Paciente ADD CONSTRAINT Paciente_Sector_FK FOREIGN KEY ( id_sector ) REFERENCES Sector ( id_sector ) ;

ALTER TABLE Paciente ADD CONSTRAINT Paciente_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Receta_Medica ADD CONSTRAINT Rec_Medica_Ficha_Paciente_FK FOREIGN KEY ( id_ficha_paciente ) REFERENCES Ficha_Paciente ( id_ficha_paciente ) ;

ALTER TABLE Receta_Medica ADD CONSTRAINT Rec_Medica_Medicamentos_FK FOREIGN KEY ( id_medicamentos ) REFERENCES Medicamentos ( id_medicamentos ) ;

ALTER TABLE Region ADD CONSTRAINT Region_Pais_FK FOREIGN KEY ( id_pais ) REFERENCES Pais ( id_pais ) ;

ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_Jornada_laboral_FK FOREIGN KEY ( id_jornada_laboral ) REFERENCES Jornada_laboral ( id_jornada_laboral ) ;

ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Comuna_FK FOREIGN KEY ( id_comuna ) REFERENCES Comuna ( id_comuna ) ;

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Genero_FK FOREIGN KEY ( id_genero ) REFERENCES Genero ( id_genero ) ;

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Nacionalidad_FK FOREIGN KEY ( id_nacionalidad ) REFERENCES Nacionalidad ( id_nacionalidad ) ;

ALTER TABLE Consultorio ADD CONSTRAINT Consultorio_Comuna_FK FOREIGN KEY ( id_comuna ) REFERENCES Comuna ( id_comuna ) ;

ALTER TABLE Alergia_Paciente ADD CONSTRAINT Aler_Pac_Alerg_FK FOREIGN KEY ( id_alergia ) REFERENCES Alergia ( id_alergia ) ;

ALTER TABLE Alergia_Paciente ADD CONSTRAINT Aler_Pac_Paciente_FK FOREIGN KEY ( id_paciente ) REFERENCES Paciente ( id_paciente ) ;
