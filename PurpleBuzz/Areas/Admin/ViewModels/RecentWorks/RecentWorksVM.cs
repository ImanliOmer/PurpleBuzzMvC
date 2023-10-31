using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurpleBuzz.Areas.Admin.ViewModels.RecentWorks
{
	public class RecentWorksVM
	{
		public int Id { get; set; }
		public string CardTitle { get; set; }
		public string CardText { get; set; }
		[Required, NotMapped]
		public IFormFile Photo { get; set; }
	}
}
