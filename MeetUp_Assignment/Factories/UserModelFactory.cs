using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetUp_Assignment.Factories
{
    public class UserModelFactory :IUserModelFactory
    {
        #region Methods

       /// <summary>
       /// Method to prepare request data to user register model
       /// </summary>
       /// <param name="userRegisterModel">user save model object</param>
       /// <returns></returns>
        public RegisterUser PrepareUserRegisterModel(UserRegisterModel userRegisterModel)
        {
            var model = new RegisterUser
            {
                Name = userRegisterModel.Name,
                Address = userRegisterModel.Address,
                Age = Convert.ToInt64(userRegisterModel.Age),
                Profession = userRegisterModel.Profession,
                NoOfGuest = Convert.ToInt64(userRegisterModel.NoOfGuest),
                Locality = userRegisterModel.Locality,
                DateOfBirth = Convert.ToDateTime(userRegisterModel.DateOfBirth),
                IsDeleted =false,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
            };
            return model;
        }

        /// <summary>
        /// Method to prepare request data to update register model
        /// </summary>
        /// <param name="userUpdateModel">Update request model object </param>
        /// <returns></returns>
        public RegisterUser PrepareUserUpdateModel(UserUpdateModel userUpdateModel)
        {
            var model = new RegisterUser
            {
                Name = userUpdateModel.Name,
                Address = userUpdateModel.Address,
                Age = Convert.ToInt64(userUpdateModel.Age),
                Profession = userUpdateModel.Profession,
                NoOfGuest = Convert.ToInt64(userUpdateModel.NoOfGuest),
                Locality = userUpdateModel.Locality,
                DateOfBirth = Convert.ToDateTime(userUpdateModel.DateOfBirth),
                UpdatedOn = DateTime.Now,
            };
            return model;
        }

        public UserModel PrepareUserViewModel(RegisterUser registerUser)
        {
            var model = new UserModel
            {
                Name = registerUser.Name,
                Address = registerUser.Address,
                Age = Convert.ToString(registerUser.Age),
                Profession = registerUser.Profession,
                NoOfGuest = Convert.ToString(registerUser.NoOfGuest),
                Locality = registerUser.Locality,
                DateOfBirth = registerUser.DateOfBirth.ToString("yyyy-MM-dd"),
                UpdatedOn = registerUser.UpdatedOn.ToString("yyyy-MM-dd"),
                CreatedOn = registerUser.CreatedOn.ToString("yyyy-MM-dd"),
            };
            return model;
        }

        #endregion
    }
}
