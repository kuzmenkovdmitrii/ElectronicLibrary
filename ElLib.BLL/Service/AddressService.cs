using System.Collections.Generic;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.BLL.Service
{
    public class AddressService : IAddressService
    {
        readonly IAddressRepository addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public IEnumerable<Address> GetAll()
        {
            return addressRepository.GetAll();
        }

        public Address GetById(int id)
        {
            return addressRepository.GetById(id);
        }

        public void Create(Address item)
        {
            addressRepository.Create(item);
        }

        public void Update(Address item)
        {
            addressRepository.Update(item);
        }

        public void Delete(int id)
        {
            addressRepository.Delete(id);
        }
    }
}
