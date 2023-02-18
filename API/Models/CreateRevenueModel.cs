using System;

namespace API.Models
{
    public class CreateRevenueModel : CreateGenericModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Value { get; set; }
    }
}