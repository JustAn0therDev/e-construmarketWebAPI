using DAO.Interfaces;
using Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DAO
{
    /// <summary>
    /// Classe de interação com repositório de Produtos
    /// </summary>
    public class ProdutoDAO : IProdutoDAO
    {
        public IEnumerable<Produto> GetAll()
        {
            string jsonContent = File.ReadAllText("produtos.json");
            return JsonConvert.DeserializeObject<IEnumerable<Produto>>(jsonContent);
        }
    }
}
