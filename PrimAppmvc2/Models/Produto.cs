using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimAppmvc2.Models
{
    public class Produto
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int categoriaId { get; set; }
        public Categoria categoria { get; set; }
    }
}
