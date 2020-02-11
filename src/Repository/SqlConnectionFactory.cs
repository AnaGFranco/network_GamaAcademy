using System.Data.SqlClient;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository
{
    public class SqlConnectionFactory
    {
        public static SqlConnection Create()
        {
            return new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True;Database=GAMA_REDE_SOCIAL");
        }
    }
}
