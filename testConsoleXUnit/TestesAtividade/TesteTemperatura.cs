using Gerenciador_de_Livros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Termologia;

namespace TestesAtividade
{
    public class TesteTemperatura
    {
        [Fact]
        public void TestarMetodoConvertor()
        {
            //Arrange : Organizar
            double celsius = 20;

            var respostaEsperada = 68;

            //Act : Agir
            var resposta = CalcularTemperatura.CelsiusParaFahrenheit(celsius);

            //Assert : Provar
            Assert.Equal(respostaEsperada, resposta);
        }
    }
}
