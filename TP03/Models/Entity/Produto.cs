using System.ComponentModel.DataAnnotations;

namespace TP03.Models.Entity
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "Preço deve ser positivo")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Quantidade Estoque:")]
        [Range(0, Int32.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero")]
        public int QtdEstoque { get; set; }
    }
}
