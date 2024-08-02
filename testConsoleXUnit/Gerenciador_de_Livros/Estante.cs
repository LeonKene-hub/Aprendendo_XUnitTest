using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Livros
{
    public class Estante
    {
        public string? Genero { get; set; }


        public bool AdicionarLivro(Livro livro)
        {
            if (livro.Genero == Genero)
            {
                Console.WriteLine("Livro adicionado");
                return true;
            }
            else
            {
                Console.WriteLine("Estante errada");
                return false;
            }
        }
    }
}
