using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {

            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Teste 1", 9.99m));
            livros.Add(new Livro("002", "Teste 2", 8.99m));
            livros.Add(new Livro("003", "Teste 3", 7.99m));
            return livros;
        }
    }
}
