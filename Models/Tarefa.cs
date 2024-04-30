#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Api_Metas.Models.Enuns;

namespace
#pragma warning restore IDE0005 // Using directive is unnecessary.
Api_Metas.Models
{
    public class Tarefa
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string Meta { get; set;}
        public float Valor { get; set;}
        public float Tempo { get; set;}
        public string Urgencia { get; set;}
        [NotMapped]
       // public int Forca { get; set; }
        public ClasseEnuns Classe{get; set;}
       // 
        public string Forca { get; internal set; }
    }
}