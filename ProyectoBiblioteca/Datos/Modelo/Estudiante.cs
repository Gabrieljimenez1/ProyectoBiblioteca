using System.ComponentModel.DataAnnotations;

namespace ProyectoBiblioteca.Datos.Modelo
{
    public class Estudiante
    {
        [Key]
        public int Identificacion { get; set; }

        public string Nombre { get; set; }

        public string Carrera { get; set; }

        public string Genero { get; set; }

        public int Edad { get; set; }
    }
}
