//using System.Linq;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Api_Metas.Models;
using Api_Metas.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace Api_Metas.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefasExemploController: ControllerBase
    {
        private static List<Tarefa> tarefas = new List<Models.Tarefa>()
        {
            new Tarefa() {Id = 1, Nome= "Luiz",Meta="Compra uma moto", Valor=10000, Tempo=2,Urgencia="baixa"  },
             new Tarefa() {Id = 2, Nome= "Asteris",Meta="Compra uma casa", Valor=400000, Tempo=20,Urgencia="baixa"},
              new Tarefa() {Id = 3, Nome= "Elizabete",Meta="Compra um vestido", Valor=400, Tempo=1,Urgencia="alta"},
               new Tarefa() {Id = 4, Nome= "Rafael",Meta="Compra uma TV", Valor=2000, Tempo=1,Urgencia="alta"}
        };
        private object listaFinal;

        public IActionResult First
        {
            get
            {
                Tarefa t = tarefas[0];
                return Ok(t);
            }
        }

        public IActionResult Get()
        {
            return Ok(tarefas);
        }

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(tarefas[0]);
        }

       /* [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(tarefas);
        }*/

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(tarefas.FirstOrDefault(ta => ta.Id == id));
        }

        [HttpPost]
        public IActionResult AddTarefas(Tarefa novaTarefas)
        {
            tarefas.Add(novaTarefas);
            return Ok(tarefas);
        }
        
        [HttpGet("GetOrdenado")]
        public IActionResult GetOrdem()
        {
            List<Tarefa> listafinal = tarefas.OrderBy(t => t.Forca).ToList();
                
            return Ok(listaFinal);
        }

       /* [HttpGet("GetSomaForca")]
        public IActionResult GetSomaForca()
        {
            return Ok("")
        }*/

        [HttpPut]
        public IActionResult UpdateTarefa(Tarefa t)
        {
            Tarefa pernsagemAlterado = tarefas.Find(tar => tar.Id == t.Id);
            pernsagemAlterado.Nome = t.Nome;
            pernsagemAlterado.Meta = t.Meta;
            pernsagemAlterado.Valor = t.Valor;
            pernsagemAlterado.Tempo = t.Tempo;
            pernsagemAlterado.Urgencia = t.Urgencia;
            pernsagemAlterado.Classe = t.Classe;

            return Ok(tarefas);  
        }
        public int Id { get; }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            tarefas.RemoveAll(tar => tar.Id == id);
            return Ok(tarefas);
        }

        [HttpGet("GetByEnum/{enumId}")]
            
        public IActionResult GetByEnum(int enumId)
        {
            ClasseEnuns enumDigitado = (ClasseEnuns)enumId;

            List<Tarefa> listaBusca = tarefas.FindAll(t => t.Classe == enumDigitado);
            return Ok(listaBusca);
        }

        
        
        
    }
}