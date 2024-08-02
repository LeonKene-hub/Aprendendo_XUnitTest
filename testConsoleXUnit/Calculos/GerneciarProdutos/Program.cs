using GerneciarProdutos;
Inventario inventario = new Inventario();
Produto produto1 = new Produto();
Produto produto2 = new Produto();

inventario.produtos = [produto1, produto2];

produto1.Nome = "produto1";
produto1.Quantidade = 2;
produto2.Nome = "produto2";

inventario.AdicionarProduto(produto1);
inventario.Pesquisar("produto1");