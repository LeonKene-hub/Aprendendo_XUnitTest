using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //AAA : Act, Arrange, Assert
        //AAA : Agir, Organizar e Assertir
        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrange : Organizar
            var x1 = 4.1;
            var x2 = 5.9;

            var somaEsperado = 10;
            var subEsperado = 1.8000000000000007;
            var mulEsperado = 24.189999999999998;

            //Act : Agir
            var soma = Calculo.Somar(x1, x2);
            var subtracao = Calculo.Subtrair(x2, x1);
            var multiplicacao = Calculo.Multiplicar(x1, x2);


            //Assert : Provar
            Assert.Equal(mulEsperado, multiplicacao);
        }
    }
}
