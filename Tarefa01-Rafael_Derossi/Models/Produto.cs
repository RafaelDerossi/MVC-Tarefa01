using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefa01_Rafael_Derossi.Models
{
    public class Produto
    {
        [Key]        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe um nome.")]
        [MinLength(2, ErrorMessage = "Nome deve ter no mínimo 2 caracteres")]
        [MaxLength(200, ErrorMessage = "Nome deve ter no máximo 200 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe um fabricante.")]
        [MinLength(2, ErrorMessage = "Fabricante deve ter no mínimo 2 caracteres")]
        [MaxLength(200, ErrorMessage = "Fabricante deve ter no máximo 200 caracteres")]
        public string Fabricante { get; set; }

        [Display(Name = "Código de Barras")]        
        public string CodigoDeBarras { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe um preço.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe um estoque.")]
        public int Estoque { get; set; }

    }
}
