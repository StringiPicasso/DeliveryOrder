using System.ComponentModel.DataAnnotations;

namespace DeliveryOrder.Models
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SenderCity { get; set; }

        [Required]
        public string SenderAddress { get; set; }

        [Required]
        public string RecipientCity { get; set; }

        [Required]
        public string RecipientAddress { get; set; }

        [Required]
        public double Weight { get; set; }
       
        [Required]
        public DateTime PickupDate { get; set; }
    }
}
