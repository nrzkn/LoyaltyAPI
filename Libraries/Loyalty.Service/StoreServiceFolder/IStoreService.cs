using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.StoreServiceFolder
{
    public interface IStoreService
    {
        /// <summary>
        /// Get Owner by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        StoreDTO GetById(int id);

        /// <summary>
        /// Delete Store
        /// </summary>
        /// <param name="store"></param>
        void DeleteStore(StoreDTO store);

        /// <summary>
        /// Get All Stores
        /// </summary>
        /// <returns></returns>
        List<StoreDTO> GetAllStores();

        /// <summary>
        /// Insert Store
        /// </summary>
        /// <param name="storeDTO"></param>
        void InsertStore(StoreDTO storeDTO);

        /// <summary>
        /// Update Owner
        /// </summary>
        /// <param name="storeDTO"></param>
        void UpdateStore(StoreDTO storeDTO);
    }
}
