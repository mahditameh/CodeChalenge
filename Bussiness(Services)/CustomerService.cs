
using Domain;
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bussiness_Services_
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _appDbContext;

        public CustomerService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Customer> Add(Customer model)
        {
            var customr = await (_appDbContext.Customers.AddAsync(model));
            await _appDbContext.SaveChangesAsync();

            return customr.Entity;
        }

        public async Task<bool> Delete(Customer customer)
        {
            var cutomer = _appDbContext.Customers.Remove(customer);
            var reult = await _appDbContext.SaveChangesAsync();

            return reult == 1;
        }

        public Task DeleteAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Customer> Get(int id)
        {
            var customer = await _appDbContext.Customers.Where(x => x.Id == id).FirstOrDefaultAsync();

            return customer;
        }

        public async Task<List<Customer>> GetAll()
        {
            var customers = await _appDbContext.Customers.OrderBy(x => x.FirstName).ToListAsync();

            return customers;
        }

        public async Task<bool> Update(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
            var result = await _appDbContext.SaveChangesAsync();

            return result == 1;
        }
    }
}
