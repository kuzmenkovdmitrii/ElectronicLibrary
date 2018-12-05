using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class AddressRepository : CommonRepository, IAddressRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        private readonly string sql =
            @"SELECT country.[Name] CountryName, city.[Name] CityName, Street, Home
                FROM Addresses
                JOIN Countries country
                ON country.Id = CountryId
                JOIN Cities city
                ON city.Id = CityId";

        public IEnumerable<Address> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Address GetById(int id)
        {
            Address address;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(StoredProcedure.SELECT_ADDRESS_BY_ID, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                da.SelectCommand = cmd;

                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                address = dt.AsEnumerable().Select(a => new Address()
                    {
                        Id = (int) a["Id"],
                        Country = (string) a["Country"],
                        City = (string) a["City"],
                        Street = (string) a["Street"],
                        Home = (string) a["Home"]
                    }
                ).FirstOrDefault();
            }

            return address;
        }

        public void Create(Address item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Address item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
