namespace API.Models
{
    public class UpdateCardModel
    {
        public string Name { get; set; }     
        public string Description { get; set; }
        public int Number { get; set; }
        public decimal  Limit{ get; set; }
    }
}