using System.ComponentModel.DataAnnotations;

namespace OrderFlow.Models
{
    // Order properties
    public class Order
    {
        [Required]
        public decimal OrderAmount { get; set; }

        [Required]
        public bool IsCustomerLoyal { get; set; }

        public decimal OrderDiscount { get; set; }
        public decimal FinalAmount { get; set; }

        // Order methods
        public void CalculateDiscount()
        {
            if (OrderAmount >= 100 && IsCustomerLoyal == true)
            {
                OrderDiscount = OrderAmount * 0.10m;
            }
            else
            {
                OrderDiscount = 0;
            }
            FinalAmount = OrderAmount - OrderDiscount;

        }



    }
}
