using CentralStorageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralStorageSystem.Repos
{
    public class FundingSourceRepo
    {
        public static List<FundingSource> GetAllFundingSources()
        {
            var fundingSources = new List<FundingSource>();

            DB.OpenConnection();
            var reader = DB.GetDataReader("SELECT * FROM IzvoriFinanciranja");

            while(reader.Read())
            {
                fundingSources.Add(CreateObject(reader));
            }
            reader.Close();
            DB.CloseConnection();

            return fundingSources;
        }

        private static FundingSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Naziv"].ToString();

            FundingSource fundingSource = new FundingSource
            {
                Id = id,
                Name = name,
            };

            return fundingSource;
        }
    }
}
