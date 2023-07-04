using FoodDelivery.Dto;
using FoodDelivery.Models;

namespace FoodDelivery.Interfaces
{
    public interface IAddressRepo
    {
        public Task<AddressModel> GetAddress(int id);
        public Task UpdateAddress(int id, AddressForUpdateDto address);
    }
}
