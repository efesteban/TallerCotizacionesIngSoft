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
    public class Cotizacion
    {
        public int Id { get; set; }

        public double Valor { get; set; }

        public bool Estado { get; set; }

        public int ClienteID { get; set; }

        public string Descripcion { get; set; }

        public string Fecha {get;set;}

    }
}