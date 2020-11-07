using AutoMapper;
using Loyalty.Core.Domain;
using Loyalty.Data;
using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loyalty.Service.StoreServiceFolder
{
    public class StoreService : IStoreService
    {
        #region Fields
        private readonly IRepository<Store> _storeRepository;
        private readonly IMapper _mapper;
        private LoyaltyDbContext _loyaltyDbContext;
        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="storeRepository"></param>
        /// <param name="mapper"></param>
        /// <param name="loyaltyDbContext"></param>
        public StoreService(IRepository<Store> storeRepository, IMapper mapper, LoyaltyDbContext loyaltyDbContext)
        {
            this._loyaltyDbContext = loyaltyDbContext;
            this._mapper = mapper;
            this._storeRepository = storeRepository;
        }
        #endregion

        #region Method
        /// <summary>
        /// Delete the Store
        /// </summary>
        /// <param name="store"></param>
        public void DeleteStore(StoreDTO store)
        {
            if (store == null)
                throw new ArgumentNullException("Store is null!");
            store.IsDeleted = true;
            store.DeletedTime = DateTime.Now;
            UpdateStore(store);
        }

        /// <summary>
        /// Get All Stores
        /// </summary>
        /// <returns></returns>
        public List<StoreDTO> GetAllStores()
        {
            var stores = _storeRepository.GetAll();
            return _mapper.Map<List<StoreDTO>>(stores);
        }

        /// <summary>
        /// Get Store by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StoreDTO GetById(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("Id is 0");
            return _mapper.Map<StoreDTO>(_storeRepository.GetById(id));
        }

        /// <summary>
        /// Insert Store
        /// </summary>
        /// <param name="storeDTO"></param>
        public void InsertStore(StoreDTO storeDTO)
        {
            if (storeDTO == null)
                throw new ArgumentNullException("Store is null!");
            _storeRepository.Insert(_mapper.Map<Store>(storeDTO));
        }

        /// <summary>
        /// Update Store
        /// </summary>
        /// <param name="storeDTO"></param>
        public void UpdateStore(StoreDTO storeDTO)
        {
            if (storeDTO == null)
                throw new ArgumentNullException("Store is null!");
            var store = _loyaltyDbContext.Stores.FirstOrDefault(x => x.ID == storeDTO.ID);
            store.Name = storeDTO.Name;
            store.OwnerId = storeDTO.OwnerId;
            store.Phone = storeDTO.Phone;
            store.UpdatedTime = DateTime.Now;
            store.Address = storeDTO.Address;
            _storeRepository.Update(store);
        }
        #endregion
    }
}
