﻿using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity3.Models
{
	public class Product
	{
		// Add necessary atributes
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[Range(0.01, 10000)]
		public string Price { get; set; }

		[Required]
		public string Category { get; set; }
	}
}
