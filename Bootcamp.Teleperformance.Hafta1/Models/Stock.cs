using System.ComponentModel.DataAnnotations;

namespace Bootcamp.Teleperformance.Hafta1.Models
{
    public class Stock : IModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Min { get; set; }
        [Required]
        public int Max { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
