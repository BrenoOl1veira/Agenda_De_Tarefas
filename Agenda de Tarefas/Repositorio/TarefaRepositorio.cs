using Agenda_de_Tarefas.Data;
using Agenda_de_Tarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public TarefaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public TarefaModel ListarPorId(int id)
        {
            return _bancoContext.Tarefas.FirstOrDefault(x => x.Id == id);
        }

        public List<TarefaModel> BuscarTodos()
        {
            return _bancoContext.Tarefas.ToList();
        }

        public TarefaModel Adicionar(TarefaModel tarefa)
        {
            _bancoContext.Tarefas.Add(tarefa);
            _bancoContext.SaveChanges();
            
            return tarefa;
        }

        public TarefaModel Atualizar(TarefaModel tarefa)
        {
            TarefaModel tarefaDB = ListarPorId(tarefa.Id);

            if (tarefaDB == null) throw new Exception("Houve um erro na atualização da Tarefa!");

            tarefaDB.Titulo = tarefa.Titulo;
            tarefaDB.Descricao = tarefa.Descricao;
            tarefaDB.Data = tarefa.Data;
            tarefaDB.Inicio = tarefa.Inicio;
            tarefaDB.Fim = tarefa.Fim;
            tarefaDB.Prioridade = tarefa.Prioridade;
            tarefaDB.Finalizada = tarefa.Finalizada;

            _bancoContext.Tarefas.Update(tarefaDB);
            _bancoContext.SaveChanges();

            return tarefaDB;
        }

        public bool Apagar(int id)
        {
            TarefaModel tarefaDB = ListarPorId(id);
            
            if (tarefaDB == null) throw new Exception("Houve um erro ao deletar o contato!");

            _bancoContext.Tarefas.Remove(tarefaDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
