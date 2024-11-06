using Microsoft.AspNetCore.Mvc;

namespace PleinLeSac.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FruitController : ControllerBase
	{

		[HttpGet("{fruitId:int}")]
		public ActionResult Index(int fruitId)
		{
			if (fruitId == 1)
				return Ok("Banane");
			else if (fruitId == 2)
				return Ok("Poire");
			else
				return BadRequest("Ce fruit n'existe pas");
		}





	}
}
