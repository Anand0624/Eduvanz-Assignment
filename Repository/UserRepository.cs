using MeetUp.Services;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UserRepository : RepositoryBase<RegisterUser>, IUserRepository 
    {
        #region Constructor
        public UserRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
        { 
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method to get all registed user list with pagination
        /// </summary>
        /// <param name="pageNumber">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="count">Output params to get total count</param>
        /// <returns></returns>
        public List<RegisterUser> GetAllUsers(int pageNumber, int pageSize, out int count) 
        {
            var data = FindAll();
            if (pageNumber > 0 && pageSize > 0)
            {
                count = data.Where(m => m.IsDeleted == false).Count();
                return data.Where(m=>m.IsDeleted==false).OrderBy(ow => ow.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                count = data.Where(m => m.IsDeleted == false).Count();
                return FindAll().Where(m => m.IsDeleted == false)
                .OrderBy(ow => ow.Id)
                .ToList();
            }
        }

        /// <summary>
        /// Method to get user details with pagination and based on search result
        /// </summary>
        /// <param name="pageNumber">PageIndex</param>
        /// <param name="pageSize">PageSize</param>
        /// <param name="count">Output params to get total count</param>
        /// <param name="name">Search by name param</param>
        /// <param name="locality">Search by locality param</param>
        /// <returns></returns>
        public List<RegisterUser> GetAllUsersWithSearch(int pageNumber, int pageSize, out int count, string name=null, string locality=null)
        {
            var data = FindAll();
            if (!string.IsNullOrWhiteSpace(name))
                data = FindAll().Where(m => m.Name.ToLower().Contains(name.ToLower()));
            if (!string.IsNullOrWhiteSpace(locality))
                data = FindAll().Where(m => m.Locality.ToLower().Contains(locality.ToLower()));
            count = data.Count();
            return data.Where(m=>m.IsDeleted==false).OrderBy(ow => ow.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        /// <summary>
        /// Method to get user by its userid
        /// </summary>
        /// <param name="userId">Iser id</param>
        /// <returns></returns>
        public RegisterUser GetUserById(Int64 userId)
        {
            return FindByCondition(owner => owner.Id.Equals(userId))
                .FirstOrDefault();
        }

        /// <summary>
        /// Method to save user details 
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(RegisterUser user)
        {
            Create(user);
        }

        /// <summary>
        /// Method to update perticular user
        /// </summary>
        /// <param name="user"></param>
        public void UpdateUser(RegisterUser user)
        {
            Update(user);
        }

        /// <summary>
        /// Method to delete perticular user
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(RegisterUser user)
        {
            Delete(user);
        }

        /// <summary>
        /// Method to get total user count
        /// </summary>
        /// <returns></returns>
        public Int64 UserCount()
        {
            return FindAll().Where(m=>m.IsDeleted==false).Count();
        }
        #endregion
    }
}
