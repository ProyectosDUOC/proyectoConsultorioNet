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
    id_consultorio int NOT NULL,
    rut_consultorio int,
    dv char(1),
    id_comuna INT NOT NULL,
    nombre NVARCHAR(30)
  );
  ALTER TABLE Consultorio ADD CONSTRAINT Consultorio_PK PRIMARY KEY ( id_consultorio ) ;

CREATE TABLE Alergia
  (
    id_alergia INT NOT NULL ,
    nombre NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Alergia ADD CONSTRAINT Alergia_PK PRIMARY KEY ( id_alergia ) ;

CREATE TABLE Provincia
  (
    id_provincia INT NOT NULL ,
    nom_com NVARCHAR (30) ,
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
    id_control_acceso INT NOT NULL ,
    usuario NVARCHAR (30) NOT NULL ,
    contrasena NVARCHAR (30) NOT NULL ,
    id_tipo_usuario INT NOT NULL,
    activo INT
  ) ;
ALTER TABLE Control_Acceso ADD CONSTRAINT Control_Acceso_PK PRIMARY KEY ( id_control_acceso ) ;


CREATE TABLE Enfermera
  (
    id_enfermera       INT NOT NULL ,
    id_usuario         INT  NOT NULL ,
    id_jornada_laboral INT  NOT NULL
  ) ;
ALTER TABLE Enfermera ADD CONSTRAINT Enfermera_PK PRIMARY KEY ( id_enfermera ) ;


CREATE TABLE Especialidad
  (
    id_especialidad INT NOT NULL ,
    nom_especialidad NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Especialidad ADD CONSTRAINT Especialidad_PK PRIMARY KEY ( id_especialidad ) ;


CREATE TABLE Ficha_Paciente
  (
    id_ficha_paciente INT NOT NULL ,
    id_consultorio    INT NOT NULL ,
    id_secretaria     INT NOT NULL ,
    id_Medico         INT NOT NULL ,
    id_enfermera      INT NOT NULL ,
    id_paciente       INT NOT NULL ,
    peso              INT NOT NULL ,
    estatura          INT NOT NULL ,
    imc               INT NOT NULL ,
    temperatura       INT NOT NULL ,
    sistonica         INT NOT NULL ,
    distolica         INT NOT NULL ,
    pulsacion         INT NOT NULL ,
    diastolica        INT NOT NULL
  ) ;
ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_PK PRIMARY KEY ( id_ficha_paciente ) ;


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
    id_sector          INT NOT NULL
  ) ;
ALTER TABLE Jornada_laboral ADD CONSTRAINT Jornada_laboral_PK PRIMARY KEY ( id_jornada_laboral ) ;


CREATE TABLE Licencia_Medica
  (
    id_licencia_medica INT NOT NULL ,
    numero_de_dias     INT NOT NULL ,
    motivos NVARCHAR (30) NOT NULL ,
    id_ficha_paciente INT NOT NULL
  ) ;
ALTER TABLE Licencia_Medica ADD CONSTRAINT Licencia_Medica_PK PRIMARY KEY ( id_licencia_medica ) ;


CREATE TABLE Medicamentos
  (
    id_medicamentos INT NOT NULL ,
    nombre NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Medicamentos ADD CONSTRAINT Medicamentos_PK PRIMARY KEY ( id_medicamentos ) ;


CREATE TABLE Medico
  (
    id_Medico  INT NOT NULL ,
    rut_medico INT NOT NULL ,
    dv_medico NVARCHAR (1) NOT NULL ,
    id_usuario         INT NOT NULL ,
    id_especialidad    INT NOT NULL ,
    id_jornada_laboral INT NOT NULL
  ) ;
ALTER TABLE Medico ADD CONSTRAINT Medico_PK PRIMARY KEY ( id_Medico ) ;


CREATE TABLE Nacionalidad
  (
    id_nacionalidad INT  NOT NULL ,
    nom_nacio NVARCHAR (30)
  ) ;
ALTER TABLE Nacionalidad ADD CONSTRAINT Nacionalidad_PK PRIMARY KEY ( id_nacionalidad ) ;


CREATE TABLE Paciente
  (
    id_paciente        INT NOT NULL ,
    id_usuario         INT NOT NULL ,
    id_grupo_sanguineo INT NOT NULL ,
    id_rh              INT NOT NULL ,
    id_sector          INT NOT NULL ,
    id_alergia         INT NOT NULL 
  ) ;
ALTER TABLE Paciente ADD CONSTRAINT Paciente_PK PRIMARY KEY ( id_paciente ) ;


CREATE TABLE Pais
  (
    id_pais INT NOT NULL ,
    nom_pais NVARCHAR (30) NOT NULL
  ) ;
ALTER TABLE Pais ADD CONSTRAINT Pais_PK PRIMARY KEY ( id_pais ) ;


CREATE TABLE Receta_Medica
  (
    id_Receta_Medica INT NOT NULL ,
    fecha            DATE NOT NULL ,
    cantidad         INT NOT NULL ,
    hora             INT NOT NULL ,
    dia              INT NOT NULL ,
    glosa NVARCHAR (300) NOT NULL ,
    id_ficha_paciente INT NOT NULL ,
    id_medicamentos   INT NOT NULL
  ) ;
ALTER TABLE Receta_Medica ADD CONSTRAINT Receta_PK PRIMARY KEY ( id_Receta_Medica ) ;


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
    id_secretaria      INT NOT NULL ,
    id_usuario         INT NOT NULL ,
    id_jornada_laboral INT NOT NULL
  ) ;
ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_PK PRIMARY KEY ( id_secretaria ) ;


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
    rut_usuario INT NOT NULL ,
    dv_usuario NVARCHAR (1) NOT NULL ,
    foto NVARCHAR(30) NOT NULL ,
    pnombre NVARCHAR (30) NOT NULL ,
    snombre NVARCHAR (30) ,
    appaterno NVARCHAR (30) NOT NULL ,
    apmaterno NVARCHAR (30) NOT NULL ,
    fecha_nacimiento DATE NOT NULL ,
    direccion NVARCHAR (30) ,
    fono1             INT ,
    fono2             INT ,
    id_control_acceso INT NOT NULL ,
    id_comuna         INT NOT NULL ,
    id_nacionalidad   INT NOT NULL ,
    id_genero         INT NOT NULL ,
    activo            INT NOT NULL
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
  id_desvinculado INT NOT NULL,
  id_usuario      INT NOT NULL,
  fecha           DATE,
  id_tipo_desvin  INT NOT NULL,
  glosa           NVARCHAR(30),
);
ALTER TABLE Desvinculado ADD CONSTRAINT Desvinculado_PK PRIMARY KEY ( id_desvinculado ) ;

ALTER TABLE Desvinculado ADD CONSTRAINT tipoDesc_Desvinculado_FK FOREIGN KEY ( id_tipo_desvin ) REFERENCES Tipo_Desvinculado (id_tipo_desvin);
ALTER TABLE Desvinculado ADD CONSTRAINT Usuario_Desvinculado_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Comuna ADD CONSTRAINT Comuna_Provincia_FK FOREIGN KEY ( id_provincia ) REFERENCES Provincia ( id_provincia ) ;

ALTER TABLE Provincia ADD CONSTRAINT Provincia_Region_FK FOREIGN KEY ( id_region ) REFERENCES Region ( id_region ) ;

ALTER TABLE Control_Acceso ADD CONSTRAINT Control_Acceso_Tipo_Usuario_FK FOREIGN KEY ( id_tipo_usuario ) REFERENCES Tipo_Usuario ( id_tipo_usuario ) ;

ALTER TABLE Enfermera ADD CONSTRAINT Enfermera_Jornada_laboral_FK FOREIGN KEY ( id_jornada_laboral ) REFERENCES Jornada_laboral ( id_jornada_laboral ) ;

ALTER TABLE Enfermera ADD CONSTRAINT Enfermera_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_Enfermera_FK FOREIGN KEY ( id_enfermera ) REFERENCES Enfermera ( id_enfermera ) ;

ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_Medico_FK FOREIGN KEY ( id_Medico ) REFERENCES Medico ( id_Medico ) ;

ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_Paciente_FK FOREIGN KEY ( id_paciente ) REFERENCES Paciente ( id_paciente ) ;

ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_Secretaria_FK FOREIGN KEY ( id_secretaria ) REFERENCES Secretaria ( id_secretaria ) ;

ALTER TABLE Ficha_Paciente ADD CONSTRAINT Ficha_Paciente_Consultori_FK FOREIGN KEY ( id_consultorio ) REFERENCES Consultorio ( id_consultorio ) ;


ALTER TABLE Jornada_laboral ADD CONSTRAINT Jornada_laboral_Sector_FK FOREIGN KEY ( id_sector ) REFERENCES Sector ( id_sector ) ;

ALTER TABLE Licencia_Medica ADD CONSTRAINT Lic_Medica_Ficha_Paciente_FK FOREIGN KEY ( id_ficha_paciente ) REFERENCES Ficha_Paciente ( id_ficha_paciente ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Especialidad_FK FOREIGN KEY ( id_especialidad ) REFERENCES Especialidad ( id_especialidad ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Jornada_laboral_FK FOREIGN KEY ( id_jornada_laboral ) REFERENCES Jornada_laboral ( id_jornada_laboral ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Usuario_FK FOREIGN KEY ( id_usuario ) REFERENCES Usuario ( id_usuario ) ;

ALTER TABLE Paciente ADD CONSTRAINT Paciente_Alergia_FK FOREIGN KEY ( id_alergia ) REFERENCES Alergia ( id_alergia ) ;

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

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Control_Acceso_FK FOREIGN KEY ( id_control_acceso ) REFERENCES Control_Acceso ( id_control_acceso ) ;

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Genero_FK FOREIGN KEY ( id_genero ) REFERENCES Genero ( id_genero ) ;

ALTER TABLE Usuario ADD CONSTRAINT Usuario_Nacionalidad_FK FOREIGN KEY ( id_nacionalidad ) REFERENCES Nacionalidad ( id_nacionalidad ) ;

ALTER TABLE Consultorio ADD CONSTRAINT Consultorio_Comuna_FK FOREIGN KEY ( id_comuna ) REFERENCES Comuna ( id_comuna ) ;

-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                            22
-- CREATE INDEX                             0
-- ALTER TABLE                             49
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ORDS DROP SCHEMA                         0
-- ORDS ENABLE SCHEMA                       0
-- ORDS ENABLE OBJECT                       0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
