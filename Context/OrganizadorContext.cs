using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dio_Dotnet_API_Desafio.Entities;

namespace Dio_Dotnet_API_Desafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) 
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }   
    }
}