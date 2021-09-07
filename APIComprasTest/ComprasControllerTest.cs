using APICompras.Controllers;
using APICompras.Models;
using APICompras.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APIComprasTest
{
    public class ComprasControllerTest
    {
        ComprasController _controller;
        ICompraService _service;

        public ComprasControllerTest()
        {
            _service = new CompraServiceFake();
            _controller = new ComprasController(_service);
        }

        [Fact]
        public void Get_Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Asserts
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<CompraItem>>(okResult.Value);
            Assert.Equal(5, items.Count);
        }
    }
}
