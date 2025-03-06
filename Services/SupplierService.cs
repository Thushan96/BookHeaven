using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookHeaven2.Data.Models;
using BookHeaven2.Data.Repository.Interfaces;

namespace BookHeaven2.Services
{
    public class SupplierService
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public async Task<Supplier?> GetSupplierByIdAsync(Guid supplierId)
        {
            return await supplierRepository.GetByIdAsync(supplierId);
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await supplierRepository.GetAllAsync();
        }

        public async Task CreateSupplierAsync(Supplier supplier)
        {
            if (supplier == null) throw new ArgumentNullException(nameof(supplier));
            await supplierRepository.CreateAsync(supplier);
        }

        public async Task UpdateSupplierAsync(Supplier supplier)
        {
            if (supplier == null) throw new ArgumentNullException(nameof(supplier));
            await supplierRepository.UpdateAsync(supplier);
        }

        public async Task DeleteSupplierAsync(Guid supplierId)
        {
            await supplierRepository.DeleteAsync(supplierId);
        }

        public async Task<IEnumerable<SupplierOrder>> GetOrdersBySupplierIdAsync(Guid supplierId)
        {
            return await supplierRepository.GetOrdersBySupplierIdAsync(supplierId);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersByNameAsync(string name)
        {
            return await supplierRepository.GetByNameAsync(name);
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersByContactInfoAsync(string contactInfo)
        {
            return await supplierRepository.GetByContactInfoAsync(contactInfo);
        }

        public async Task<IEnumerable<SupplierOrder>> GetOrdersByStatusAsync(Guid supplierId, string status)
        {
            return await supplierRepository.GetOrdersByStatusAsync(supplierId, status);
        }
    }
}
