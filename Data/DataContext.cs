/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;*/
using Api_Metas.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Metas.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Tarefa> TB_Metas{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().ToTable("TB_Metas");
            modelBuilder.Entity<Tarefa>().HasData
            (
             new Tarefa() {Id = 1, Nome= "Luiz",Meta="Compra uma moto", Valor=10000, Tempo=2,Urgencia="baixa"  },
             new Tarefa() {Id = 2, Nome= "Asteris",Meta="Compra uma casa", Valor=400000, Tempo=20,  Urgencia="baixa"},
             new Tarefa() {Id = 3, Nome= "Elizabete",Meta="Compra um vestido", Valor=400, Tempo=1,Urgencia="alta"},
             new Tarefa() {Id = 4, Nome= "Rafael",Meta="Compra uma TV", Valor=2000, Tempo=1,Urgencia="alta"}
            );
        }
       /* protected override void ConfigureCoventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }*/
    }
}