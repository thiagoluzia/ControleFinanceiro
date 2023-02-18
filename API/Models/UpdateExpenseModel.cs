using System;

namespace API.Models
{
    public class UpdateExpenseModel
    {
       public string Name   { get; set; } 
       public string Description { get; set; }
       public DateTime DueDate { get; set; }
       public decimal Value { get; set; }
    }
}