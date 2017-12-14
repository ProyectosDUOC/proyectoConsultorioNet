# HOSPITAL PROYECT WEB
- [Funcionamiento detallado](#funcionamiento-detallado)
- [Acerca de](#acerca-de)
  - [Incio sesión](#incio-sesión) 
  - [Pasos a seguir](#pasos-a-seguir)
- [Imagenes Paso A Pasos](#imagenes-paso-a-pasos)
- [Programacion destacada](#programacion-destacada)
  - [CRUD](#crud )
  - [Coleccion](#coleccion)  
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
| Tecnologia #10 | Modelo Capa de Presentacion | Gridview |
| Tecnologia #11 | Modelo Capa de Presentacion | HTML |
| Tecnologia #12 | Modelo Capa de Presentacion | CSS |
| Tecnologia #13 | Modelo Capa de Presentacion | Session |
| Tecnologia #14 | Modelo Capa de Servicio | Servicio web IIS Envio |
| Tecnologia #15 | Modelo Capa de Servicio | Servicio web Recibiendo |

## Acerca de 

Proyecto Consultorio es una aplicacion web creada en el ramo de Desarrollo en .NET en el segundo semestre del año 2017,
basandose en los datos semana a semana y lo visto en clase.

***
# Funcionamiento

### Incio sesión
* Agregar SQL (SQL Server)
* Abir Archivo **proyectoConsultorioNet-master\ConsultorioRemake\Consultorio\Consultorio.sln**  

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
* using System.Data.Entity; | clase consultorio.cs {id ,rut, dv, idComuna, nombre}
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
## Coleccion 
* Clase consultorio.cs {id ,rut, dv, idComuna, nombre}
```csharp - C
   public static List<Consultorio> GenerarListado(List<capaDatos.Consultorio> ConsultorioDALC)
        {
            List<capaNegocio.Consultorio> consultorios= new List<Consultorio>();

            foreach (capaDatos.Consultorio consul in ConsultorioDALC)
            {
                capaNegocio.Consultorio consultorio = new Consultorio();

                consultorio.Id = consul.id_consultorio;
                consultorio.Rut = (int)consul.rut_consultorio;
                consultorio.Dv = Char.Parse(consul.dv);
                consultorio.IdComuna = (int)consul.id_comuna;
                consultorio.Nombre = consul.nombre;
                
                consultorios.Add(consultorio);
            }
            return consultorios;
        }

        //Listado de todos los elementos

        public List<Consultorio> ReadAll()
        {
            var consultorios = CommonBC.ModeloConsultorio.Consultorio;
            return GenerarListado(consultorios.ToList());
        }

       
    }
```
## CommonBC 
* Clase consultorio.cs {id ,rut, dv, idComuna, nombre}
```csharp - C
using capaDatos;

namespace capaNegocio
{
    public class CommonBC
    {
        private static ConsultoriosEntities _modeloConsultorio;

        public static ConsultoriosEntities ModeloConsultorio
        {
            get
            {
                if (_modeloConsultorio == null)
                {
                    _modeloConsultorio = new ConsultoriosEntities();
                }
                return _modeloConsultorio;
            }
        }
        public CommonBC() { }
    }
}
```

## xml app config
* App.Config
```xml - XML
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="ConsultoriosEntities" connectionString="metadata=res://*/ConsultorioEDM.csdl|res://*/ConsultorioEDM.ssdl|res://*/ConsultorioEDM.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=DESKTOP-26I1PO8\SQLEXPRESS;Initial Catalog=Consultorios;Integrated Security=True;MultipleActiveResultSets=True&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
</configuration>
```

## Session 
* Logi.aspx coneccion con Session | clase controlAcceso {id, usuario, pass, tipoUsuario, activo}
```csharp - C
        private ControlAcceso controlAcceso
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Session["MiUsuario"] = new ControlAcceso();
                }
                return (ControlAcceso)Session["MiUsuario"];
            }
            set { Session["MiUsuario"] = value; }
        }

```
## DropDownList
Conexion a pada de negocio clase coleccion 
1. En web .aspx (Combo Box) 
  * Cuadro de herramientas - "ObjectDataSource" - Cargar la coleccion de capa de negocios
  * poner DropDownList y Elegir origin de ODS
  * en el DDL borrar el id de object y despues borrar object
  * En el controlador de la pagina poner lo siguiente **pagina.aspx.cs**
```csharp - C
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {    
                ddGenero.DataSource = capaNegocio.GeneroColeccion.ReadAll(); //Rellena
                ddGenero.DataBind(); // Muestra en ventana
            }
        }
```
2. Seleccionar un encontrado 
* ddGenero = DropDownList llamado ddGenero {Masculino, Femenino, Prefiero no decirlo, Otro}
* SelectedIndex = Seleciona uno de la posicion X
```csharp - C
         ddGenero.SelectedIndex = ddGenero.Items.IndexOf(ddGenero.Items.FindByValue(usuario.IdGenero.ToString()));              
```
3. Guardar el seleccionado 
* ddGenero = DropDownList llamado ddGenero {Masculino, Femenino, Prefiero no decirlo, Otro}

```csharp - C
        //Guardar el id de genero  
        String id = ddGenero.SelectedIndex + 1;  //Masculino[0] , Femenino[1] , etc..
        
        //Guarda el valor de lo asignado en el DDL
        String id = ddGenero.SelectedItem;
```

## Gridview
Conexion a pada de negocio clase coleccion 
1. En web .aspx (Lista) 
  * Cuadro de herramientas - "ObjectDataSource" - Cargar la coleccion de capa de negocios
  * poner Gridview y Elegir origin de ODS
  * en el gv borrar el id de object y despues borrar object
  * En el controlador de la pagina poner lo siguiente **pagina.aspx.cs**
```csharp - C
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                GridView1.DataSource = capaNegocio.ClasesListar.PacienteLColeccion.GenerarListado();
                GridView1.DataBind();
            }
        }
```
2. Habilitar Paginacion
* Ir a propiedades de su GV **PageSize = 10** (cantidad de paginas max) 
* Ir a los eventos de su GV **PageIndexChanged = paginas** (doble click para programar el evento)
```csharp - C
         GridView1.PageIndex = e.NewPageIndex; //Para hablitar el cambio de pagina
         
         GridView1.DataSource = capaNegocio.ClasesListar.PacienteLColeccion.GenerarListado(); // Lo mismo que !IsPostBack
         GridView1.DataBind();            
```
3. Habilitar Seleccionar
* En tareas de GV **habilitar Seleccion**
* Ir a los eventos de su GV **SelectedIndexChanged = Seleccionar** (doble click para programar el evento)

**Tabla Saludo** (id = GridView1)
| Seleccionar | Id | Nombre |
| -- | -- | -- |
| GridView1.SelectedRow.Cells[0].Text | GridView1.SelectedRow.Cells[1].Text | GridView1.SelectedRow.Cells[2].Text |
| Seleccionar | 1 | Hola |
| Seleccionar | 1 | Hola |
| Seleccionar | 2 | Hola1 |
| Seleccionar | 3 | Hola2 |
| Seleccionar | 4 | Hola3 |
```csharp - C
         protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text); //Seleccionariamos el id
        }
 
 ```                    
