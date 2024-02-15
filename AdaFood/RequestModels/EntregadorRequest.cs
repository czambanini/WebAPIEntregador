using System.ComponentModel.DataAnnotations;

namespace AdaFood.RequestModels
{
    public class EntregadorRequest
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

    }
}