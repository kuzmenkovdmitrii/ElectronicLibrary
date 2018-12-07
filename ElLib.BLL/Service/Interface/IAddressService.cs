using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IAddressService
    {
        IEnumerable<Address> GetAll();
        Address GetById(int id);
        void Create(Address item);
        void Update(Address item);
        void Delete(int id);
    }
}
