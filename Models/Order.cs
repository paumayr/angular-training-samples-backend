
namespace angular_training_samples_backend.Models
{
    public class Order 
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public decimal Amount { get; set; }

        public string[] Items { get; set; } 
    }
}