using System.Configuration;
using System.Data.SqlClient;

namespace JUDAKE.DataAccess.Connection
{
    public static class GetConnection
    {
        public static SqlConnection JUDAKE()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["JUDAKE"].ConnectionString);
            return con;
        }
    }
}
