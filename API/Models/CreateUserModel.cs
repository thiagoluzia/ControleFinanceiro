namespace API.Models
{
    public class CreateUserModel : CreateGenericModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}