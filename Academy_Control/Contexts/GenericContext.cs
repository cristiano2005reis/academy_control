using Academy_Control.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Academy_Control.Contexts
{
    public class GenericContext:DbContext
    {
        public GenericContext() : base("academy_control")
        {

        }
        
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<AlunosTurmas> AlunosTurmas { get; set; }
        public DbSet<Mensalidades> Mensalidades { get; set; }
        public DbSet<Modalidades> Modalidades { get; set; }
        public DbSet<Professores> Professores { get; set; }
        public DbSet<Turmas> Turmas { get; set; }
        public DbSet<Valores> Valores { get; set; }
    }
}