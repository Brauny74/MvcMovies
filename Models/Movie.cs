using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace L11.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		[Display(Name = "Название")]
		public string Title { get; set; }

		[Display(Name = "Дата выхода")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
		public DateTime ReleaseDate { get; set; }

		[Required]
		[RegularExpression(@"^[A-ZА-Я]+[a-zA-Zа-яА-Я\s]*$")]
		[StringLength(30)]
		[Display(Name = "Жанр")]
		public string Genre { get; set; }

		[Range(1, 1000)]
		[DataType(DataType.Currency)]
		[Display(Name = "Цена")]
        [DisplayFormat(DataFormatString = "{0} руб", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

		[Display(Name ="Возрастное ограничение")]
		[RegularExpression(@"^[0-9]*\+$")]
		public string Rating { get; set; }
	}
}
