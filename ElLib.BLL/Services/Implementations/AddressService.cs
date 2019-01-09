using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
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

        public Address GetById(int? id)
        {
            ThrowException.CheckNull(id);

            return addressRepository.GetById(id);
        }

        public OperationDetails Create(Address item)
        {
            ThrowException.CheckNull(item);

            addressRepository.Create(item);

            return new OperationDetails(true, "Адрес успешно создан");
        }

        public OperationDetails Update(Address item)
        {
            ThrowException.CheckNull(item);

            addressRepository.Update(item);

            return new OperationDetails(true, "Адрес успешно обновлён");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckNull(id);

            addressRepository.Delete(id);
            return new OperationDetails(true, "Адрес успешно удалён");
        }
    }
}
