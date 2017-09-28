INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (1,'Polen')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (2,'Acaros')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (3,'Polvo')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (4,'Penicilina')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (5,'Aspirina')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (6,'Lactosa')
INSERT INTO [Consultorios].[dbo].[Alergia] VALUES (7,'Gruten')

INSERT INTO [Consultorios].[dbo].[Pais] VALUES (1,'Argentina')
INSERT INTO [Consultorios].[dbo].[Pais] VALUES (2,'Chile')
INSERT INTO [Consultorios].[dbo].[Pais] VALUES (3,'Brazil')
INSERT INTO [Consultorios].[dbo].[Pais] VALUES (4,'Mexico')

INSERT INTO [Consultorios].[dbo].[Region] VALUES (1,'Metropolitana',1)

INSERT INTO [Consultorios].[dbo].[Comuna] VALUES (1,'San Bernardo',1)
INSERT INTO [Consultorios].[dbo].[Comuna] VALUES (2,'Calera de tango',1)
INSERT INTO [Consultorios].[dbo].[Comuna] VALUES (3,'Santiago',1)
INSERT INTO [Consultorios].[dbo].[Comuna] VALUES (4,'Buin',1)

INSERT INTO [Consultorios].[dbo].[Consultorio] VALUES (1,19999992,'1',1,'Consutorio mi Duoc')
INSERT INTO [Consultorios].[dbo].[Consultorio] VALUES (2,19999911,'k',2,'Consutorio el Campo')
  

INSERT INTO [Consultorios].[dbo].[Tipo_Usuario] VALUES (1,'paciente')
INSERT INTO [Consultorios].[dbo].[Tipo_Usuario] VALUES (2,'secretaria')
INSERT INTO [Consultorios].[dbo].[Tipo_Usuario] VALUES (3,'enfermera')
INSERT INTO [Consultorios].[dbo].[Tipo_Usuario] VALUES (4,'medico')
INSERT INTO [Consultorios].[dbo].[Tipo_Usuario] VALUES (5,'administrador')

                          -- id regitros vinculado a una cuenta, usuario , pass , tipo de usuario, activo
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (1,'paciente','paciente',1,1) -- siempre fijo no hace nada
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (2,'medico69C','medico23',4,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (3,'secretariaMaria','secretaria1313',2,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (4,'enfermeraNaty','naty132',2,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (5,'supervisor','root2017',5,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (6,'Manuel24','Alambre24',3,0)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (7,'soporteconsultorio','root',5,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (8,'carlos','cAr102',4,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (9,'seba','seba',2,1)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (10,'root','DuocAdmin',5,0)
INSERT INTO [Consultorios].[dbo].[Control_Acceso] VALUES (11,'paty','paty',2,1)


INSERT INTO [Consultorios].[dbo].[Sector] VALUES (1,'Amarillo')
INSERT INTO [Consultorios].[dbo].[Sector] VALUES (2,'Rojo')
INSERT INTO [Consultorios].[dbo].[Sector] VALUES (3,'Azul')
INSERT INTO [Consultorios].[dbo].[Sector] VALUES (4,'Naranjo')
INSERT INTO [Consultorios].[dbo].[Sector] VALUES (5,'Blanco')

INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (1,1,1,1,1,1,1,1,1)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (2,1,2,2,3,2,1,2,2)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (3,1,1,2,1,1,1,1,2)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (4,1,2,1,2,1,1,1,1)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (5,1,2,1,2,1,1,1,3)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (6,1,1,1,1,1,3,1,4)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (7,1,3,2,1,2,1,1,2)
INSERT INTO [Consultorios].[dbo].[Jornada_laboral] VALUES (8,1,1,1,3,2,2,1,5)

INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (1,'Chileno')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (2,'Argentino')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (3,'Mexicano')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (4,'Aleman')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (5,'Peruano')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (6,'Ruso')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (7,'Norcoreano')
INSERT INTO [Consultorios].[dbo].[Nacionalidad] VALUES (8,'Haitiano')

INSERT INTO [Consultorios].[dbo].[Grupo_sanguineo] VALUES (1,'Grupo A')
INSERT INTO [Consultorios].[dbo].[Grupo_sanguineo] VALUES (2,'Grupo B')
INSERT INTO [Consultorios].[dbo].[Grupo_sanguineo] VALUES (3,'Grupo AB')
INSERT INTO [Consultorios].[dbo].[Grupo_sanguineo] VALUES (4,'Grupo O')

INSERT INTO [Consultorios].[dbo].[Rh_sanguineo] VALUES (1,'Negativo')
INSERT INTO [Consultorios].[dbo].[Rh_sanguineo] VALUES (2,'Positivo')

INSERT INTO [Consultorios].[dbo].[Especialidad] VALUES (1,'Medicina General')
INSERT INTO [Consultorios].[dbo].[Especialidad] VALUES (2,'Obtetricia')
INSERT INTO [Consultorios].[dbo].[Especialidad] VALUES (3,'Cirujano')
INSERT INTO [Consultorios].[dbo].[Especialidad] VALUES (4,'Veterinario')

INSERT INTO [Consultorios].[dbo].[Genero] VALUES (1,'Masculino')
INSERT INTO [Consultorios].[dbo].[Genero] VALUES (2,'Femenino')
INSERT INTO [Consultorios].[dbo].[Genero] VALUES (3,'Others')

INSERT INTO [Consultorios].[dbo].[Medicamentos] VALUES (1,'Paracetamol')
INSERT INTO [Consultorios].[dbo].[Medicamentos] VALUES (2,'Ibuprofeno')
INSERT INTO [Consultorios].[dbo].[Medicamentos] VALUES (3,'Aspirina')
INSERT INTO [Consultorios].[dbo].[Medicamentos] VALUES (4,'Ketorolaco')
--                                               num, rut   , dv , dire foto, nombre, snom, appate, apmate , fecha nac , direcion          , fono 1   , fono 2 ,id control, id comun ,id nacionalidad, id genero, activo
INSERT INTO [Consultorios].[dbo].[Usuario] VALUES (1, 
											19000000,'1',
											'foto1',
											'Benjamin','Elias','Mora','Torres',
											'1995-04-21' ,
											'Los crisantemos 327',
											9829999,
											28550,
											1,
											2,
											1,
											1,
											1)
