using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class AddressRepository : CommonRepository<Address>, IAddressRepository
    {
        public AddressRepository(
            IProcedureExecuter executer, 
            IParameters<Address> parameters, 
            IConverter<Address> converter)
            :base(executer)
        {
            EntityName = "Address";
            TableName = "Addresses";
            Parameters = parameters;
            Converter = converter;
        }
    }
}
