using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetByName(string firstName)
        {
            var sql = "SELECT * FROM TB_USER WHERE NM_USER = @name";

            var parameters = new { name = firstName };

            return Execute<User>(sql, parameters);
        }
    }
}
