using Microsoft.AspNetCore.Mvc;

namespace ProyectoBiblioteca.Controllers
{
	[ApiController]
	[Route("[Controller]/[action]")]

	public class BibliotecaController: ControllerBase
	{
		public string PropiedadesBilbioteca { get; set; }

		public BibliotecaController()
		{
			//Constructor
		}
		[HttpGet]

		public string ObtenerLibro() 
		{ 
			return "Ok Bro no molestes";
		}

		[HttpPut]

		public string ActualizarLibro()
		{
			return "Ok Bro no molestes";
		}

		[HttpPost]

		public string AgregarLibro()
		{
			return "Ok Bro no molestes";
		}

		[HttpDelete]
		public string BorrarLibro()
		{
			return "Ok Bro no molestes";
		}

		//Prestamo
		[HttpGet]

		public string ObtenerPrestamo()
		{
			return "Ok Bro no molestes";
		}

		[HttpPut]

		public string ActualizarPrestamo()
		{
			return "Ok Bro no molestes";
		}

		[HttpPost]

		public string AgregarPrestamo()
		{
			return "Ok Bro no molestes";
		}

		[HttpDelete]
		public string BorrarPrestamo()
		{
			return "Ok Bro no molestes";
		}

		//Autor

		[HttpGet]
		public string ObtenerAutor()
		{
			return "Ok Bro no molestes";
		}

		[HttpPut]

		public string ActualizarAutor()
		{
			return "Ok Bro no molestes";
		}

		[HttpPost]

		public string AgregarAutor()
		{
			return "Ok Bro no molestes";
		}

		[HttpDelete]
		public string BorrarAutor()
		{
			return "Ok Bro no molestes";
		}

		//Estudiante

		[HttpGet]
		public string ObtenerEstudiante()
		{
			return "Ok Bro no molestes";
		}

		[HttpPut]

		public string ActualizarEstudiante()
		{
			return "Ok Bro no molestes";
		}

		[HttpPost]

		public string AgregarEstudiante()
		{
			return "Ok Bro no molestes";
		}

		[HttpDelete]
		public string BorrarEstudiante()
		{
			return "Ok Bro no molestes";
		}

	}
}
