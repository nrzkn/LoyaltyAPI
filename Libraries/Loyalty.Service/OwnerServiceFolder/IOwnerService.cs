using Loyalty.Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Service.OwnerServiceFolder
{
    public interface IOwnerService
    {
        /// <summary>
        /// Get Owner by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OwnerDTO GetById(int id);

        /// <summary>
        /// Delete Owner
        /// </summary>
        /// <param name="owner"></param>
        void DeleteOwner(OwnerDTO owner);

        /// <summary>
        /// Get All Owners
        /// </summary>
        /// <returns></returns>
        List<OwnerDTO> GetAllOwners();

        /// <summary>
        /// Insert Owner
        /// </summary>
        /// <param name="owner"></param>
        void InsertOwner(OwnerDTO owner);

        /// <summary>
        /// Update Owner
        /// </summary>
        /// <param name="owner"></param>
        void UpdateOwner(OwnerDTO owner);
    }
}
