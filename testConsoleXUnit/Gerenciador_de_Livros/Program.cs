// See https://aka.ms/new-console-template for more information
using Gerenciador_de_Livros;

Livro livro = new Livro();
livro.Nome = "You should put some dirt in your eyes";
livro.Genero = "Comedia";

Estante estante = new Estante();
estante.Genero = "Comedia";

estante.AdicionarLivro(livro);
