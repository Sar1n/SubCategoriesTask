using Microsoft.AspNetCore.Mvc;

namespace SubCategoriesTask.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SubCategoriesController : ControllerBase
	{
		[HttpGet(Name = "GetCategories")]
		public IEnumerable<Category> Get()
		{
			return new List<Category>()
			{
				new(1, "1", null),
				new(2, "2", 1),
				new(3, "3", 2),
				new(4, "4", 2),
				new(5, "5", 2),
				new(6, "6", 4),
				new(7, "7", 4),
				new(8, "8", 4),
				new(9, "9", 8),
			};
		}
	}
}