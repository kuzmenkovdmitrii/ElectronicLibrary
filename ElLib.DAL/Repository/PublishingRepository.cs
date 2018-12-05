using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class PublishingRepository : CommonRepository, IPublishingRepository
    {
        public string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        IAddressRepository addressRepository;

        public PublishingRepository(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public IEnumerable<Publishing> GetAll()
        {
            throw new NotImplementedException();
        }

        public Publishing GetById(int id)
        {
            Publishing publishing;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(StoredProcedure.SELECT_PUBLISHING_BY_ID, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                da.SelectCommand = cmd;

                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                foreach (var p in dt.AsEnumerable())
                {
                    int Id = (int) p["Id"];
                    string Name = (string) p["Name"];
                    string Country = (string) p["Country"];
                    string City = (string) p["City"];
                    string Street = (string) p["Street"];
                    string Home = (string) p["Home"];
                }


                publishing = dt.AsEnumerable().Select(p => new Publishing()
                    {
                        Id = (int) p["Id"],
                        Name = (string) p["Name"],
                        Address = addressRepository.GetById((int) p["AddressId"])
                    }
                ).FirstOrDefault();
            }

            return publishing;

            return null;
        }

        public void Create(Publishing item)
        {
            throw new NotImplementedException();
        }

        public void Update(Publishing item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}