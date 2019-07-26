using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnospeed.Database.Models;
using Tecnospeed.Database.Repositories;
using Tecnospeed.NFSE.Controllers;
using Tecnospeed.NFSE.Models;
using Xunit;

namespace Tecnospeed.NFSE.Tests
{
    public class E2ETests
    {
        private readonly NFSEController controller;
        
        public E2ETests()
        {
            var authentication = new Authentication();
            var nfseHandler = new NFSEHandler(authentication);
            var repository = new NfseRepository(new TecnospeedDbContextFactory());
            this.Initialize();
            this.controller = new NFSEController(nfseHandler, repository);
        }

        private void Initialize() {
            TecnospeedData.host = "https://managersaashom.tecnospeed.com.br:7071/ManagerAPIWeb/nfse";
            TecnospeedData.user = "admin";
            TecnospeedData.password = "123mudar";
            TecnospeedData.cnpj = "08187168000160";
            TecnospeedData.grupo = "edoc";
            TecnospeedData.inscMunicipal = "56713126";
            TecnospeedData.nomeCidade = "PortoAlegreRS"; 
        }


        [Fact]
        public async Task SendNFSE_ReturnsOk_when_DataIsValid()
        {
            //Act
            var result = await this.controller.Post(new RequestData());

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<CreatedResult>();
        }
    }
}
