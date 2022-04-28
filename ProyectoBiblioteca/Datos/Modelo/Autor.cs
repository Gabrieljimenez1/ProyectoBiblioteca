using System.ComponentModel.DataAnnotations;
namespace ProyectoBiblioteca.Datos.Modelo
{
    public class Autor
    {
		[Key]
		public int Identificacion { get; set; }

		public string Nombre { get; set; }
	}
}
