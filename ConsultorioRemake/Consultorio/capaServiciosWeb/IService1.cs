using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace capaServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        String rutPacienteId(int id);

        [OperationContract]
        String nombrePacienteIdFicha(int id);

        [OperationContract]
        String rutMedicoIdFicha(int id);

        [OperationContract]
        String nombreMedicoId(int id);

        [OperationContract]
        String cantidadMedicamento(int idFicha,int idMedicamento);

      
        // TODO: agregue aquí sus operaciones de servicio
       // [OperationContract]
      //  PacienteFicha buscarPaciente(int id);
    }

    //bool recibirReceta(STring rutPac, String nombre, String rutDoc, String nombre, Idde ficha, cant, idMedicamento)
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
 
    
  /* [DataContract]
    public class PacienteFicha
    {
        String idUsuario;

        String idPaciente;

        [DataMember]
        public String IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        String rut; //100000-1

        [DataMember]
        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        String nombres; //Nombre Completo

        [DataMember]
        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        
        String apellidos;

        [DataMember]
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        int edad;

        [DataMember]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        String genero;

        [DataMember]
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        String direccion;

        [DataMember]
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        String correo;

        [DataMember]
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        int contacto;

        [DataMember]
        public int Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        int comunaCodigo;

        [DataMember]
        public int ComunaCodigo
        {
            get { return comunaCodigo; }
            set { comunaCodigo = value; }
        }
        


        [DataMember]
        public String IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        
       
    }*/
}
