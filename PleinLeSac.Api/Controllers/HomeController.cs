using Microsoft.AspNetCore.Mvc;
using PleinLeSac.Api.Models;

namespace PleinLeSac.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class HomeController : ControllerBase
	{

		[HttpGet]
		public ActionResult Index()
		{
			return Ok("Here is the index");
		}

		[HttpGet("/birdPerson.jpg")]
		public ActionResult Bird()
		{
			return Ok(new BirdPerson { Name = "Pag", Height = 177 });
		}







	}
}
