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
        //Arrange : Organizar
        [Theory]
        [InlineData("pedrogmail.com")]
        [InlineData("pedro@gmailcom")]
        [InlineData("pedro@gmail.com")]
        public void TestarMetodoValidarEmail(string email)
        {
            //Act : Agir
            var resposta = Email.ValidarEmail(email);

            //Assert : Provar
            Assert.True(resposta);
        }
    }
}
