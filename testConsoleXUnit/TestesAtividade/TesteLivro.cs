using Gerenciador_de_Livros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAtividade
{
    public class TesteLivro
    {
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            //Arrange : Organizar
            Livro livro = new Livro();

            livro.Nome = "You should put some dirt in your eyes";
            livro.Genero = "Comedia";

            Estante estante = new Estante();
            estante.Genero = "Comedia";

            //Act : Agir
            var resposta = estante.AdicionarLivro(livro);

            //Assert : Provar
            Assert.True(resposta);
        }
    }
}
