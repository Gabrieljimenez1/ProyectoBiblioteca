using System.ComponentModel.DataAnnotations;
namespace ProyectoBiblioteca.Datos.Modelo
{
    public class Prestamo
    {
		[Key]
		public Boolean EstaPrestado { get; set; }
	}
}
