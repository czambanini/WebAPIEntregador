using System.ComponentModel.DataAnnotations;

namespace AdaFood.RequestModels
{
    public class EntregadorRequest
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "O CPF deve conter 11 digitos")]
        [MinLength(11, ErrorMessage = "O CPF deve conter 11 digitos")]
        public string CPF { get; set; }

    }
}