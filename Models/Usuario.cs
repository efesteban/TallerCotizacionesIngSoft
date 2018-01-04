/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Cotizaciones.Models {

    /// <summary>
    /// Clase que representa a una persona en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Usuario : Persona
    {
        public int Perfil {get;set;}
        public string Contraseña {get;set;}

    }
}