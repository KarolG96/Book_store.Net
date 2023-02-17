
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Dispaly Order")]
        [Range(1, 100, ErrorMessage = "Display Oreder must be between 1 and 100 only!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDataTime { get; set; } = DateTime.Now;

    }
}

