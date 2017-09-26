using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    //Usuario
    public enum Genero
    {
        Seleccione, Femenino, Masculino
    };

    //medico
    public enum Especialidad
    {
        Seleccione, Medicina_General, Dentista
    };

   


    //Paciente 
    public enum GrupoSanguineo
    {
        Seleccione, GrupoA, GrupoB, GrupoAB, GrupoO
    };

    public enum RhSanguineo
    {
        Seleccione, Rh_Positivo, Rh_Negativo
    };

    public enum Sector
    {
        Seleccione, Amarillo, Naranjo, Azul, Verde, Celeste
    };
}
