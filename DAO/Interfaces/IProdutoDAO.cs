using Entities;
using System.Collections.Generic;

namespace DAO.Interfaces
{
    public interface IProdutoDAO
    {
        IEnumerable<Produto> GetAll(); 
    }
}
