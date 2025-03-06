using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository) {
            this.customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await customerRepository.GetAllCustomersAsync();
        }

        public async Task<Customer?> GetCustomer(Guid id)
        {
            return await customerRepository.GetCustomerByIdAsync(id);
        }

        public async Task<IEnumerable<Customer>> SearchBooks(string keyword)
        {
            return await customerRepository.SearchCustomersAsync(keyword);
        }

        public async Task AddCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            await customerRepository.AddCustomerAsync(customer);
        }

        public async Task<int?> UpdateCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            return await customerRepository.UpdateCustomerAsync(customer);
        }

        public async Task DeleteCustomer(Guid id)
        {
            await customerRepository.DeleteCustomerAsync(id);
        }
    }
}
