using Agenda_de_Tarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas.Repositorio
{
    public interface ITarefaRepositorio
    {
        TarefaModel ListarPorId(int id);
        List<TarefaModel>BuscarTodos();
        TarefaModel Adicionar(TarefaModel tarefa);
        TarefaModel Atualizar(TarefaModel tarefa);
        bool Apagar(int id);
    }
}
