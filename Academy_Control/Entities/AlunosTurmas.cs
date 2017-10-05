using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class AlunosTurmas
    {
        [Key]
        public Int32 AlunoTurmaId { get; set; }
        public Int32 AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public virtual Alunos Aluno { get; set; }
    }
}