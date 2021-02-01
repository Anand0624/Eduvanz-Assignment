using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetUp_Assignment.Factories
{
    public interface IUserModelFactory
    {
        RegisterUser PrepareUserRegisterModel(UserRegisterModel userRegisterModel);
        RegisterUser PrepareUserUpdateModel(UserUpdateModel userUpdateModel);
        UserModel PrepareUserViewModel(RegisterUser registerUser);
    }
}
