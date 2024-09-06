using System;
using System.ComponentModel.DataAnnotations;

namespace L11.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Display(Name = "Название")]
		public string Title { get; set; }

		[Display(Name = "Дата выхода")]
		[DataType(DataType.Date)] 
		public DateTime ReleaseDate { get; set; }

		[Display(Name = "Жанр")]
		public string Genre { get; set; }
		[Display(Name = "Цена")]
		public decimal Price { get; set; }

		[Display(Name ="Возрастное ограничение")]
		public string Rating { get; set; }
	}
}
