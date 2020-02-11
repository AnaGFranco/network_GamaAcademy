using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [TestClass]
    public class InviteStatusTest
    {
        private readonly IInviteStatusService _service;

        public InviteStatusTest()
        {
            RegisterMappers.Register();

            var repository = new InviteStatusRepository();

            _service = new InviteStatusService(repository);
        }


        [TestMethod]
        public void InsertStatus()
        {

            var status = new InviteStatus()
            {
                Description = "Aceito"
            };

            _service.Insert(status);

        }

    }
}
