using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVCDIO.Models
{
    public class Context :DbContext

    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CursoMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CursoMVCDIO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CursoMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
