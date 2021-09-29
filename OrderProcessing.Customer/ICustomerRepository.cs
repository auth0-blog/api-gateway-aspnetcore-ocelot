using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Customer
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetAllCustomers();
    }
}
