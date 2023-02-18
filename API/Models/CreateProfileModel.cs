namespace API.Models
{
    public class CreateProfileModel : CreateGenericModel
    {
        public string Name { get; set; }
        public string Description { get; set; }        
    }
}