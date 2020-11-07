using AutoMapper;
using Loyalty.Core.Domain;
using Loyalty.Data;
using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loyalty.Service.CustomerServiceFolder
{
    public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;
        private LoyaltyDbContext _loyaltyDbContext;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="customerRepository"></param>
        /// <param name="mapper"></param>
        public CustomerService(IRepository<Customer> customerRepository, IMapper mapper, LoyaltyDbContext loyaltyDbContext)
        {
            this._customerRepository = customerRepository;
            this._mapper = mapper;
            this._loyaltyDbContext = loyaltyDbContext;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete the Customer
        /// </summary>
        /// <param name="customerDTO"></param>
        public void DeleteCustomer(CustomerDTO customerDTO)
        {
            if (customerDTO == null)
                throw new ArgumentNullException("Parameter is null");
            customerDTO.IsDeleted = true;
            UpdateCustomer(customerDTO);
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        public List<CustomerDTO> GetAllCustomers()
        {
            var customers = _customerRepository.GetAll();
            if (customers == null)
                throw new ArgumentNullException("Parameter is null!");
            List<CustomerDTO> customersDTO = new List<CustomerDTO>();
            foreach(var item in customers)
            {
                customersDTO.Add(_mapper.Map<CustomerDTO>(item));
            }
            return customersDTO;
        }

        /// <summary>
        /// Get Customer with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CustomerDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Parameter is null!");
            var customer = _customerRepository.GetById(id);
            var customerDTO = _mapper.Map<CustomerDTO>(customer);
            return customerDTO;
        }

        /// <summary>
        /// Insert Customer 
        /// </summary>
        /// <param name="customerDTO"></param>
        public void InsertCustomer(CustomerDTO customerDTO)
        {
            if (customerDTO == null)
                throw new ArgumentNullException("Parameter is null!");
            _customerRepository.Insert(_mapper.Map<Customer>(customerDTO));
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="customerDTO"></param>
        public void UpdateCustomer(CustomerDTO customerDTO)
        {
            if (customerDTO == null)
                throw new ArgumentNullException("Parameter is null");
            var customer = _loyaltyDbContext.Customers.FirstOrDefault(x => x.ID == customerDTO.ID);
            customer.Firstname = customerDTO.Firstname;
            customer.Lastname = customerDTO.Lastname;
            customer.Surname = customerDTO.Surname;
            customer.Password = customerDTO.Password;
            customer.Address = customerDTO.Address;
            customer.Age = customerDTO.Age;
            customer.UpdatedTime = DateTime.Now;
            _customerRepository.Update(customer);
        }
        #endregion
    }
}
