using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Academy_Control.Entities
{
    public class Professores:Generic
    {
        [Key]
        public Int32 ProfessorId { get; set; }
        
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public Decimal Percentual { get; set; }
        public DateTime Data_cadastro { get; set; }
        public string Obs { get; set; }
        
        public virtual ICollection<Modalidades> Modalidades { get; set; }
        public virtual ICollection<Turmas> Turma { get; set; }
    }
}