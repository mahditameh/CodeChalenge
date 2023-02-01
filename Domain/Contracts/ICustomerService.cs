using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface ICustomerService
    {
        Task<Customer> Get(int id);
        Task<bool> Update(Customer customer);
        Task<bool> Delete(Customer customer);
        Task DeleteAll();
        Task<List<Customer>> GetAll();
        Task<Customer> Add(Customer model);
    }
}
