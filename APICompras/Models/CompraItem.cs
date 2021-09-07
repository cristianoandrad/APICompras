using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICompras.Models
{
    public class CompraItem
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Fabricante { get; set; }
    }
}
