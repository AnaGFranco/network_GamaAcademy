using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class InviteApplication : ApplicationBase<Invite>, IInviteApplication
    {
        private readonly IInviteService _service;

        public InviteApplication(IInviteService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
