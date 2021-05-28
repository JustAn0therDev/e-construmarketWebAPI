using DAO.Interfaces;
using Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class ProdutoDAOTests
    {
        [Fact]
        public void GetAllShouldReturnEnumerableOfProducts()
        {
            var produtos = new List<Produto>
            {
                new Produto
                {
                    Nome = "Teclado Mecanico",
                    Preco = 900.0M,
                    Marca = new Marca
                    {
                        Nome = "Razer",
                        CodigoMarca = Guid.NewGuid().ToString()
                    }
                },
                new Produto
                {
                    Nome = "Mouse Gamer",
                    Preco = 580.0M,
                    Marca = new Marca
                    {
                        Nome = "Razer",
                        CodigoMarca = Guid.NewGuid().ToString()
                    }
                }
            };

            Mock<IProdutoDAO> mock = new Mock<IProdutoDAO>();

            mock.Setup(instance => instance.GetAll()).Returns(produtos);

            var produtosFromDAO = mock.Object.GetAll();

            Assert.True(produtosFromDAO != null && produtosFromDAO.Any());
        }
    }
}
