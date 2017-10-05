using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class Valores
    {
        [Key]
        public Int32 ValorId { get; set; }
        public Decimal Percentual_Country { get; set; }
        public Decimal Desconto_aluno_socio { get; set; }
    }
}