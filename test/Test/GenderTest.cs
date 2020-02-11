using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class GenderTest 
    {
        private readonly IGenderService _service;

        public GenderTest()
        {
            RegisterMappers.Register();

            var repository = new GenderRepository();

            _service = new GenderService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTest()
        {
            var gender = new Gender();

            _service.Insert(gender);

            //nada mais executa depois de um estouro de exceção 
        }

        [TestMethod]
        public void IntegratedTest()
        {
            var gender = new Gender()
            {
                Description = "Indefinido"
            };

            _service.Insert(gender);
        }
    }
}
