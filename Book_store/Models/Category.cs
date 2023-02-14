using System;
using System.ComponentModel.DataAnnotations;

namespace Book_store.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime CreatedDataTime { get; set; } = DateTime.Now;

	}
}

