using DAO.Interfaces;
using e_construmarket.Controllers;
using Entities;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests.ControllerTests
{
    public class ProdutoControllerTests
    {
        [Fact]
        public void GetShouldReturnEnumerableOfProductsWithStatusCode200()
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(action => action.AddDebug());
            var logger = new Logger<ProdutoController>(loggerFactory);

            var mock = new Mock<IProdutoDAO>();

            mock.Setup(s => s.GetAll()).Returns(new List<Produto>
            {
                new Produto 
                {
                    Nome = "Teclado", 
                    Preco = 99.9M, 
                    Marca = new Marca { Nome = "Razer", CodigoMarca = Guid.NewGuid().ToString() }
                }
            });

            IProdutoDAO produtoDAO = mock.Object;

            ProdutoController controller = new ProdutoController(produtoDAO, logger);
            var result = controller.Get();

            var controllerResponseList = result.Value as List<Produto>;

            Assert.True(result.StatusCode == 200);
            Assert.True(controllerResponseList != null && controllerResponseList.Count > 0);
        }
    }
}
