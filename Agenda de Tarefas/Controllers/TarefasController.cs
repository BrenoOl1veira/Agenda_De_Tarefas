using Agenda_de_Tarefas.Models;
using Agenda_de_Tarefas.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefasController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        public IActionResult Index()
        {
            List<TarefaModel> tarefas = _tarefaRepositorio.BuscarTodos();
            return View(tarefas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            TarefaModel tarefa = _tarefaRepositorio.ListarPorId(id);
            return View(tarefa);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            TarefaModel tarefa = _tarefaRepositorio.ListarPorId(id);
            return View(tarefa);
        }
        public IActionResult Apagar(int id)
        {
            _tarefaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            _tarefaRepositorio.Adicionar(tarefa);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(TarefaModel tarefa)
        {
            _tarefaRepositorio.Atualizar(tarefa);
            return RedirectToAction("Index");
        }
    }
}
