using LojaEsportes.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace LojaEsportes.Dominio.Repositorio
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private ProdutoContexto contexto;

        public ProdutoRepositorio(ProdutoContexto produtoContexto)
        {
            this.contexto = produtoContexto;
        }

        //todos os produtos
        public IEnumerable<Produto> GetTodos()
        {
            return contexto.Produtos.ToList().OrderBy(p=> p.Nome);
        }

        //produtos por categoria
        public IEnumerable<Produto> Get(int? id)
        {
            return contexto.Produtos.Where(c => c.CategoriaId == id).OrderBy(p => p.Nome);
        }
    }
}
