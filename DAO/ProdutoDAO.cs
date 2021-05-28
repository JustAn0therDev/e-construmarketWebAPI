using Entities;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using DAO.Interfaces;

namespace DAO
{
    public class ProdutoDAO : IProdutoDAO
    {
        public IEnumerable<Produto> GetAll()
        {
            string jsonContent = File.ReadAllText("produtos.json");
            return JsonConvert.DeserializeObject<IEnumerable<Produto>>(jsonContent);
        }
    }
}
