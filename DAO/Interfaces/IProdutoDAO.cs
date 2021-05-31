using Entities;
using System.Collections.Generic;

namespace DAO.Interfaces
{
    public interface IProdutoDAO
    {
        /// <summary>
        /// Resgata todos os produtos de um repositório
        /// </summary>
        /// <returns>Coleção de produtos</returns>
        IEnumerable<Produto> GetAll(); 
    }
}
