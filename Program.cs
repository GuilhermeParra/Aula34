using System;
using Aula34.Controllers;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Listar();
            produto.Filtrar("42");
        }
    }
}
