using System.ComponentModel.DataAnnotations;

namespace Bootcamp.Teleperformance.Hafta1.Models
{
    public class Category : IModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int StokId { get; set; }
    }
}
