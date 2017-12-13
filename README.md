# HOSPITAL PROYECT WEB
- [Funcionamiento detallado](#funcionamiento-detallado)
- [Acerca de](#acerca-de)
  - [Incio sesión](#incio-sesión) 
  - [Pasos a seguir](#pasos-a-seguir)
- [Imagenes Paso A Pasos](#imagenes-paso-a-pasos)
- [Programacion destacada](#programacion-destacada)
  - [CRUD](#crud )
  - [Programacion destacada](#programacion-destacada)  
  - [Programacion destacada](#programacion-destacada)
  - [Programacion destacada](#programacion-destacada)

## Funcionamiento detallado

|nombre|Herramienta|Descripcion|
| -- | -- | -- |
| - | Visual Studio 2010 | - |
| Base de datos | MYSQL | Insertar datos y poblacion |
| Tecnologia #1 | Modelo Capa de datos | Entities System.data.Entity |
| Tecnologia #2 | Modelo Capa de datos | Entity Data Model Tools .EDMX |
| Tecnologia #3 | Modelo Capa de Negocio | CLASES .cs |
| Tecnologia #4 | Modelo Capa de Negocio | Coleccion de cada clase |
| Tecnologia #5 | Modelo Capa de Negocio | CRUD con Entity EDMX |
| Tecnologia #6 | Modelo Capa de Negocio | Clases customer |
| Tecnologia #7 | Modelo Capa de Presentacion | .aspx |
| Tecnologia #8 | Modelo Capa de Presentacion | .C# |
| Tecnologia #9 | Modelo Capa de Presentacion | DropDownList |
| Tecnologia #10 | Modelo Capa de Presentacion | Griwview |
| Tecnologia #11 | Modelo Capa de Presentacion | HTML |
| Tecnologia #12 | Modelo Capa de Presentacion | CSS |
| Tecnologia #13 | Modelo Capa de Presentacion | Session |
| Tecnologia #14 | Modelo Capa de Servicio | Servicio web IIS Envio |
| Tecnologia #15 | Modelo Capa de Servicio | Servicio web Recibiendo |

## Acerca de 

Proyecto Consultorio es una aplicacion web creada en el ramo de Desarrollo en .NET en el segundo semestre del año 2017,
basandose en los datos semana a semana y lo visto en clase. Se comenzo con la elvaracion de dicho

## Funcionamiento


### Incio sesión

|Tipo Usuario | Usuario | Constraseña|
| -- | -- | -- |
| Administrador | Bruno | 1234 |
| Secreataria (recepcionista) | Camila | 1234 |
| Enfermera | Sofia | 1234 |
| Doctor | Andres | 1234 |

## Pasos a seguir 

1. Administrador : Crear/Modificar/Listar Pacientes con datos detallados
2. Secretaria : Ingresa a la consulta un paciente X por su RUT
3. Enfermera : Chequea al paciente
4. Doctor : Evalua el estado del paciente y receta medicamentos / finaliza la consulta



## Imagenes Paso A Pasos
*: _ Logo ministerio de Salud imagen obtenida de googles Imagenes 

* Inicio Login
![Login](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/1Login.jpg?raw=true "Login")
* Administrador Agregar Paciente 
![Agregar Paciente](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/2AgregarPaciente.jpg?raw=true "titulo")
* Enfermera: Agregar Paciente a la ficha
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/5agregarPacientepara%20una%20Ficha.jpg?raw=true "titulo")
* Enfermera Selecciona
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/9Seleccionamos%20al%20paciente.jpg?raw=true "titulo")
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/6SecertariaAgregarPaciente.jpg?raw=true "titulo")
* Enfermera Ficha
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/10EjecutaLaConsulta.jpg?raw=true "titulo")
* Medico Ficha
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/13Selecciondelpaciente.jpg?raw=true "titulo")
* Medico Ficha Paciente
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/14FichaMedica.jpg?raw=true "titulo")
* Medico Agregar Medicamento
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/15AgregarMedicamento.jpg?raw=true "titulo")
* Consulta Finalizada
![Con titulo](https://github.com/ProyectosDUOC/proyectoConsultorioNet/blob/master/Fotos%20Proyecto/Fotos%20Consultorio/17FinDoctor.jpg?raw=true "titulo")


# Programacion destacada
## CRUD
##  System.Data.Entity 
* using System.Data.Entity;
```csharp - C
            public bool Read(){
            try
            {
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );              
                this.Rut = consultorio.id_consultorio;
                this.Dv = Char.Parse(consultorio.dv);
                this.IdComuna = (int)consultorio.id_comuna;
                this.Nombre = consultorio.nombre;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );                
                consultorio.rut_consultorio = this.Rut;
                consultorio.dv = this.Dv.ToString();
                consultorio.id_comuna = this.IdComuna;
                consultorio.nombre = this.Nombre;
               
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );
                CommonBC.ModeloConsultorio.DeleteObject(consultorio);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
```



