using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula34.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public List<Produto> Ler(){

                //Criando uma lista que servirá como o retorno
                List<Produto> produtos = new List<Produto>();

                //Lendo o arquivo e tranformando em um array de linhas
                // [0] = Codigo=2;Nome=Gibson;Preco=5000
                string[] linhas = File.ReadAllLines(PATH);

                foreach (string linha in linhas)
                {
                    string[] dado = linha.Split(";");
                    //Criando instância de produtos para serem colocados na lista

                    Produto p =new Produto();
                    
                    p.Codigo = int.Parse(Separar(dado[0]));
                    p.Nome = Separar(dado[1]);
                    p.Preco = float.Parse(Separar(dado[2]));
                    produtos.Add(p);

                    
                }
                produtos = produtos.OrderBy(y => y.Nome).ToList();
                return produtos;
            }
            private string Separar(string _coluna){

                //0      1
                //nome = Gibson
                return _coluna.Split ("=")[1];

            }
    }
}