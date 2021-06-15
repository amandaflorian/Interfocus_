using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Vendinha.Models{
    public class Cliente{
        public int Id {get; set;}

        [StringLength(60, MinimumLength = 10), Required, Display(Name = "Nome")]
        
        [StringLength(11, MinimumLength = 9), Required(Name = "CPF")]

        public int Idade {get; set;}                

        List<string> Dividas = new List<string>();

        [Required]
        List<string> Descricao_da_compra = new List<string>();

        [Required]
        List<string> Valor_da_compra = new List<string>();

        List<string> Data_da_compra = new List<string>();
    }
}