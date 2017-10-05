using Academy_Control.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Academy_Control.Services
{
    public class ProfessorService : GenericService<Professores>
    {
        public ProfessorService() : base (new Repositories.ProfessorRepository())
        {

        }

    }
}