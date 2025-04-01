using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity3.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		[StringLength()]
	}
}
