using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public string Prioridade { get; set; }
        public string Finalizada { get; set; }

    }
}
