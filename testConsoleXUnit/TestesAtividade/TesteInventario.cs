using GerneciarProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termologia;

namespace TestesAtividade
{
    public class TesteInventario
    {
        [Fact]
        public void TestarMetodoAdicionarProduto()
        {
            //Arrange : Organizar
            Inventario inventario = new Inventario();
            Produto produto1 = new Produto();
            Produto produto2 = new Produto();

            produto1.Nome = "produto1";
            produto1.Quantidade = 2;
            inventario.produtos = [produto1];

            produto2.Nome = "produto2";

            //inventario.AdicionarProduto(produto1);

            var respostaEsperada = "adicionado novo produto";

            //Act : Agir
            var resposta = inventario.AdicionarProduto(produto2);

            //Assert : Provar
            Assert.Equal(respostaEsperada, resposta);
        }

        [Fact]
        public void TestarMetodoPesquisar()
        {
            //Arrange : Organizar
            Inventario inventario = new Inventario();
            Produto produto1 = new Produto();

            produto1.Nome = "produto1";
            produto1.Quantidade = 2;
            inventario.produtos = [produto1];


            //Act : Agir
            var resposta = inventario.Pesquisar("produto1");

            //Assert : Provar
            Assert.True(resposta);
        }
    }
}
