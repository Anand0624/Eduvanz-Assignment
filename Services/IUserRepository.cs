using Entities.Models;
using System;
using System.Collections.Generic;

namespace MeetUp.Services
{
    public interface IUserRepository : IRepositoryBase<RegisterUser>
    {
        List<RegisterUser> GetAllUsers(int pageNumber, int pageSize, out int count);
        List<RegisterUser> GetAllUsersWithSearch(int pageNumber, int pageSize, out int count, string name=null, string locality=null);
        RegisterUser GetUserById(Int64 userId);
        void CreateUser(RegisterUser owner);
        void UpdateUser(RegisterUser owner);
        void DeleteUser(RegisterUser owner);
        Int64 UserCount();
    }
}
