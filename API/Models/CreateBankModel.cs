using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CreateBankModel : CreateGenericModel
    {
        [Required(ErrorMessage = "Informe o nome da instituição financeira", AllowEmptyStrings = false)]  
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Display(Name = "Nome do Banco")] 
        [StringLength(10, MinimumLength = 4)]
        public string Name { get; set; }

        [Display(Name = "Descrição do Banco")] 
        [StringLength(100)]
        public string Description { get; set; }
        
        [Required(ErrorMessage ="Infome um saldo para sua conta bancária")]
        [Display(Name = "Saldo Atual")] 
        [DisplayFormat(DataFormatString ="{0,c}")]
        public decimal  Balance{ get; set; }
    }
}