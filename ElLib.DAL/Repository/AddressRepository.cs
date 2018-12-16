using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class AddressRepository : CommonRepository<Address>, IAddressRepository
    {
        public AddressRepository(IParameters<Address> parameters, IConverter<Address> converter, IProcedureExecuter executer)
            :base(executer)
        {
            EntityName = "Address";
            TableName = "Addresses";
            Parameters = parameters;
            Converter = converter;
        }
    }
}
