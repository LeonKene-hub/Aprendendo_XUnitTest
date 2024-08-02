using ValidadorEmail;

string emailTeste = "pedrokis18@gmail.com";

bool resultado = Email.ValidarEmail(emailTeste);
Console.WriteLine(resultado);