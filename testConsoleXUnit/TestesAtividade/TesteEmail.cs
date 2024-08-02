using Gerenciador_de_Livros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorEmail;

namespace TestesAtividade
{
    public class TesteEmail
    {
        [Fact]
        public void TestarMetodoValidarEmail()
        {
            //Arrange : Organizar
            string email = "@.";

            var respostaEsperada = true;

            //Act : Agir
            var resposta = Email.ValidarEmail(email);

            //Assert : Provar
            Assert.Equal(respostaEsperada, resposta);
        }
    }
}
