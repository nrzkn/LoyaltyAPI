using Loyalty.Core.Domain;
using Loyalty.Data;
using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.CustomerServiceFolder
{
    public interface ICustomerService
    {
        /// <summary>
        /// Get Customer By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CustomerDTO GetById(int id);

        /// <summary>
        /// Delete Customer
        /// </summary>
        /// <param name="customerDTO"></param>
        void DeleteCustomer(CustomerDTO customerDTO);

        /// <summary>
        /// GetAll Customers
        /// </summary>
        /// <returns></returns>
        List<CustomerDTO> GetAllCustomers();

        /// <summary>
        /// Insert a Customer
        /// </summary>
        /// <param name="customerDTO"></param>
        void InsertCustomer(CustomerDTO customerDTO);

        /// <summary>
        /// Update the Customer
        /// </summary>
        /// <param name="customerDTO"></param>
        void UpdateCustomer(CustomerDTO customerDTO);
    }
}
