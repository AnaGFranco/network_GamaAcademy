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
    public class InviteTest
    {
        private readonly IInviteService _service;
        public InviteTest()
        {
            RegisterMappers.Register();

            var repository = new InviteRepository();
            var userRepository = new UserRepository();

            _service = new InviteService(repository, userRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SenderIdNull()
        {
            var invite = new Invite();

            _service.Insert(invite);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReceiverIdailNull()
        {
            var invite = new Invite()
            {
                SenderId = Guid.Parse("123e4567 - e89b - 12d3 - a456 - 426655440000")

            };

            _service.Insert(invite);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InviteStatusId()
        {
            var invite = new Invite()
            {
                SenderId = Guid.NewGuid(),
                ReceiverId = Guid.NewGuid(),
            };

            _service.Insert(invite);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SenderIdInvalid()
        {
            var invite = new Invite()
            {
                SenderId = Guid.NewGuid(),
                // ReceiverId = SenderId,
                InviteStatusId = Guid.NewGuid(),

            };

            _service.Insert(invite);
        }
    }
}
