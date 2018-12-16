using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
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

        public OperationDetails Create(Address item)
        {
            try
            {
                addressRepository.Create(item);
                return new OperationDetails(true, "Адрес успешно создан");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании адреса");
            }
        }

        public OperationDetails Update(Address item)
        {
            try
            {
                addressRepository.Update(item);
                return new OperationDetails(true, "Адрес успешно обновлён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении адреса");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                addressRepository.Delete(id);
                return new OperationDetails(true, "Адрес успешно удалён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении адреса");
            }
        }
    }
}
