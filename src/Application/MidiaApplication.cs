using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;

namespace Gama.RedeSocial.Application
{
    public class MidiaApplication : ApplicationBase<Midia>, IMidiaApplication
    {
        private readonly IMidiaService _service;

        public MidiaApplication(IMidiaService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
