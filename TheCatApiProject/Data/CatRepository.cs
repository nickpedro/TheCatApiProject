using System;
using System.Configuration;
using System.Data.SqlClient;
using TheCatApiProject.Models;

namespace TheCatApiProject.Data
{
    public class CatRepository
    {
        private readonly string _connectionString;

        public CatRepository()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["SqlConnection"]
                .ConnectionString;
        }

        public void Salvar(Cat cat)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Cats (ApiId, Url, DataBusca)
                                 VALUES (@ApiId, @Url, @DataBusca)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ApiId", cat.id);
                cmd.Parameters.AddWithValue("@Url", cat.url);
                cmd.Parameters.AddWithValue("@DataBusca", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}