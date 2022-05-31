using CentralStorageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralStorageSystem.Repos
{
    internal class EquipmentRepo
    {
        public static List<Equipment> GetAllEquipment()
        {
            List<Equipment> allEquipment = new List<Equipment>();

            DB.OpenConnection();
            string sqlSearch = "SELECT * FROM PopisOpreme";
            var reader = DB.GetDataReader(sqlSearch);
            while(reader.Read())
            {
                Equipment equipment = CreateObject(reader);
                allEquipment.Add(equipment);
            }
            reader.Close();
            DB.CloseConnection();

            return allEquipment;
        }

        public static List<Equipment> GetEquipmentByName(string searchText)
        {
            List<Equipment> foundEquipment = new List<Equipment>();
            DB.OpenConnection();
            string sql = $"SELECT * FROM PopisOpreme WHERE Naziv LIKE '%{searchText}%'";
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foundEquipment.Add(CreateObject(reader));
                }
                
            }
            return foundEquipment;
        }

        public static Equipment CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Naziv"].ToString();
            string orderer = reader["Narucitelj"].ToString();
            string fundingSource = reader["IzvorFinanciranja"].ToString();
            string type = reader["Vrsta"].ToString();
            string description = reader["Opis"].ToString();
            string timeOfReceipt = reader["VrijemePrimitka"].ToString();
            string storedBy = reader["Zaprimio"].ToString();
            string projectName = reader["NazivProjekta"].ToString();

            Equipment equipment = new Equipment
            {
                Id = id,
                Name = name,
                Orderer = orderer,
                FundingSource = fundingSource,
                Type = type,
                Description = description,
                TimeOfReceipt = timeOfReceipt,
                StoredBy = storedBy,
                ProjectName = projectName,
            };
            return equipment;
        }
    }
}
