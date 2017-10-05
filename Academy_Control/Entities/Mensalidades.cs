using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class Mensalidades
    {
        [Key]
        public Int32 MensalidadeId { get; set; }
        public Int32 AlunoId { get; set; }
        public Int32 TurmaId { get; set; }

        public DateTime Vencimento { get; set; }
        public DateTime Data_pagamento { get; set; }
        public Decimal Valor_pagar { get; set; }
        public Decimal Valor_pago { get; set; }
        public string Selecionado { get; set; }
        public DateTime Emissao { get; set; }
        public string Mes { get; set; }
        public Decimal Valor_professor { get; set; }
        public Decimal Valor_desconto_aluno { get; set; }
        public Decimal Valor_clube { get; set; }
        public Decimal Valor_academia { get; set; }

        [ForeignKey("AlunoId")]
        public virtual Alunos Aluno { get; set; }
        [ForeignKey("TurmaId")]
        public virtual Turmas Turma { get; set; }
    }
}