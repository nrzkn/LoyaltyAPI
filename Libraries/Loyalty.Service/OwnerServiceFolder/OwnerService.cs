using AutoMapper;
using Loyalty.Core.Domain;
using Loyalty.Data;
using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loyalty.Service.OwnerServiceFolder
{
    public class OwnerService : IOwnerService
    {
        #region Fields
        private readonly IRepository<Owner> _ownerRepository;
        private readonly IMapper _mapper;
        private LoyaltyDbContext _loyaltyDbContext;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="ownerRepository"></param>
        /// <param name="mapper"></param>
        /// <param name="loyaltyDbContext"></param>
        public OwnerService(IRepository<Owner> ownerRepository,
            IMapper mapper,
            LoyaltyDbContext loyaltyDbContext)
        {
            this._ownerRepository = ownerRepository;
            this._mapper = mapper;
            this._loyaltyDbContext = loyaltyDbContext;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delete Owner
        /// </summary>
        /// <param name="owner"></param>
        public void DeleteOwner(OwnerDTO owner)
        {
            if (owner == null)
                throw new ArgumentNullException("Parameter is null!");
            owner.IsDeleted = true;
            UpdateOwner(owner);
        }

        /// <summary>
        /// Get All Owners
        /// </summary>
        /// <returns></returns>
        public List<OwnerDTO> GetAllOwners()
        {
            var owners = _ownerRepository.GetAll();
            if (owners == null)
                throw new ArgumentNullException("Data cannot found!");
            List<OwnerDTO> ownerDTOs = new List<OwnerDTO>();
            foreach(var item in owners)
            {
                ownerDTOs.Add(_mapper.Map<OwnerDTO>(item));
            }
            return ownerDTOs;
        }

        /// <summary>
        /// Get Owner by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OwnerDTO GetById(int id)
        {
            if(id == 0)
                throw new ArgumentNullException("Id is 0");
            var owner = _ownerRepository.GetById(id);
            return _mapper.Map<OwnerDTO>(owner);
        }

        /// <summary>
        /// Insert the Owner
        /// </summary>
        /// <param name="owner"></param>
        public void InsertOwner(OwnerDTO owner)
        {
            if (owner == null)
                throw new ArgumentNullException("Owner is null");
            _ownerRepository.Insert(_mapper.Map<Owner>(owner));
        }

        /// <summary>
        /// Update Owner
        /// </summary>
        /// <param name="owner"></param>
        public void UpdateOwner(OwnerDTO owner)
        {
            if (owner == null)
                throw new ArgumentNullException("Owner is null");
            var owners = _loyaltyDbContext.Owners.FirstOrDefault(x => x.ID == owner.ID);
            owners.Firstname = owner.Firstname;
            owners.Lastname = owner.Lastname;
            owners.PersonelID = owner.PersonelID;
            owners.Phone = owner.Phone;
            owners.Surname = owner.Surname;
            owners.Password = owner.Password;
            if (owner.Point != 0)
                owners.Point = owner.Point;
            owners.UpdatedTime = DateTime.Now;
            _ownerRepository.Update(owners);
        }
        #endregion
    }
}
