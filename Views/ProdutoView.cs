using System.Collections.Generic;
using System;
using Aula34.Models;

namespace Aula34.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach ( Produto item in lista){
                Console.WriteLine($" {item.Codigo} R${item.Preco} - {item.Nome}");
            }

        }
    }
}