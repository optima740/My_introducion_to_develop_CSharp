﻿using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Space.AttributePrinters;
using Space.DataAccessLayer;
using Space.InputOutput;
using Space.Models;
using Space.Operations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Space.UnitTests.Operations
{
    [TestClass]
    public class PrintAllStarsOperationTest
    {
        protected Mock<IPrinter> _starPrinterMock;
        protected Mock<ISpaceObjectRepository> _repositoryMock;
        protected Mock<IOutput> _printInConsoleMock;     
        protected Star _star;      

        [SetUp]
        public void Setup()
        {
            var fixture = new Fixture();
            _star = fixture.Create<Star>();  
            _printInConsoleMock = new Mock<IOutput>();          
            _repositoryMock = new Mock<ISpaceObjectRepository>();
            _starPrinterMock = new Mock<IPrinter>();
        }

        [Test]
        public async Task PrintAllStarsOperation_ShouldPrintStarAttributes()
        {
            //Arrange            
            var printAllStarsOperation = new PrintAllStarsOperation(_repositoryMock.Object, _starPrinterMock.Object, _printInConsoleMock.Object);
            var starsCollection = new List<Star> { _star };           
            _repositoryMock.Setup(repo => repo.GetAllByTypeAsync<Star>()).Returns(starsCollection.ToAsyncEnumerable());

            //Act
            await printAllStarsOperation.DoOperationAsync();

            //Assert          
            _starPrinterMock.Verify(p => p.Print(_star));            
        }
    }
}