using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerneciarProdutos
{
    public class Inventario
    {
        public List<Produto>? produtos { get; set; }

        public string AdicionarProduto(Produto produto)
        {
            Produto achado = produtos.Find(p => p.Nome == produto.Nome);

            if (achado == null) 
            {
                Console.WriteLine(produto.Nome + ", Adicionado um novo produto");
                produtos.Add(produto);
                return "adicionado novo produto";
            }
            else
            {
                Console.WriteLine("Quantidade do produto aumentada " + produto.Nome);
                achado.Quantidade++;
                return "incrementado a quantidade";
            }
        }

        public bool Pesquisar(string nomeProduto)
        {
            Produto achado = produtos.Find(p => p.Nome == nomeProduto);

            if (achado == null)
            {
                Console.WriteLine("Produto nao achado");
                return false;
            }
            else
            {
                Console.WriteLine(achado.Nome);
                return true;
            }
        }
    }
}
