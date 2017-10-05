using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class Modalidades
    {
        [Key]
        public Int32 ModalidadeId { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public Decimal Valor_bruto { get; set; }
        public Decimal Valor_desconto { get; set; }
        public DateTime Vencimento { get; set; }
        public bool Selecionada { get; set; }
        public Decimal Valor_combo { get; set; }
    }
}