using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServicioConsultorio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string glosaRecetaMedica(int idFicha, int idMedicamento);

        [OperationContract]
        string buscarRutDoctor(int idFichaPaciente);

        [OperationContract]
        string buscarNombreDoctor(int idFichaPaciente);

        [OperationContract]
        string buscarRutPaciente(int idFichaPaciente);

        [OperationContract]
        string buscarNombrePaciente(int idFichaPaciente);


        [OperationContract]
        String rutPacienteId(int id);

        [OperationContract]
        String nombrePacienteIdFicha(int id);

        [OperationContract]
        String rutMedicoIdFicha(int id);

        [OperationContract]
        String nombreMedicoId(int id);

        [OperationContract]
        String cantidadMedicamento(int idFicha, int idMedicamento);
    }
}
