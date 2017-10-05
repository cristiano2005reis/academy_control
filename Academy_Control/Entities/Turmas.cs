using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Academy_Control.Entities
{
    public class Turmas
    {
        [Key]
        public Int32 TurmaId { get; set; }
        public Int32 ModalidadeId { get; set; }
        public Int32 ProfessorId { get; set; }

        public string Codigo { get; set; }
        public string Nome_turma { get; set; }
        public DateTime Hora_inicio { get; set; }
        public DateTime Hora_fim { get; set; }
        public string Seg { get; set; }
        public string Ter { get; set; }
        public string Qua { get; set; }
        public string Qui { get; set; }
        public string Sex { get; set; }
        public string Sab { get; set; }
        public string Dom { get; set; }

        [ForeignKey("ModalidadeId")]
        public virtual Modalidades Modalidade { get; set; }
        [ForeignKey("ProfessorId")]
        public virtual Professores Professor { get; set; }
    }
}