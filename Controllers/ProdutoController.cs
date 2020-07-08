using System.Collections.Generic;
using Aula34.Models;
using Aula34.Views;

namespace Aula34.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
           /* List<Produto> produtos = new List<Produto>;
            produtos = produtoModel.Ler();*/

            produtoView.MostrarNoConsole( produtoModel.Ler());
        }
        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarNoConsole(lista);

        }
    }
}