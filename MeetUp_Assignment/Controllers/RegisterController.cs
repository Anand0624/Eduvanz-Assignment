using AutoMapper;
using MeetUp.Services;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using MeetUp_Assignment.Factories;
using log4net;
using System.Reflection;

namespace MeetUp_Assignment.Controllers
{
    [Route("api/participants")] 
    [ApiController] 
    public class RegisterController : ControllerBase 
    {
        #region Fields
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly IUserModelFactory _usermodelfactory;
        #endregion

        #region Constructor
        public RegisterController(IRepositoryWrapper repository, IMapper mapper, IUserModelFactory userModelFactory) 
        { 
            this._repository = repository;
            this._mapper = mapper;
            this._usermodelfactory = userModelFactory;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Method to get all registered user's details 
        /// </summary>
        /// <param name="currentPage">Page Number</param>
        /// <param name="pageSize"> Page size </param>
        /// <returns></returns>
        [HttpGet]
        //[Route("userlist")]
        public IActionResult GetAllUsers(int currentPage = 1, int pageSize = 0)
        { 
            try 
            {
                var users = this._repository.User.GetAllUsers(currentPage,pageSize, out int count); 
                _log.Info("Returned all users from database.");
                return Ok(users); 
            } 
            catch (Exception ex) 
            { 
                _log.Error($"Something went wrong inside GetAllUsers action: {ex.Message}"); 
                return StatusCode(500, "Internal server error"); 
            } 
        }

        /// <summary>
        /// Method to get user details by user id
        /// </summary>
        /// <param name="id"> User Id to get user details</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "UserById")] 
        public IActionResult GetUserByUserId(Int64 id) 
        { 
            try 
            { 
                var user = this._repository.User.GetUserById(id); 
                if (user == null) 
                { 
                    _log.Error($"User with id: {id}, hasn't been found in db."); 
                    return NotFound(); 
                } 
                else 
                { 
                    _log.Info($"Returned User with id: {id}");
                    var userResult = this._usermodelfactory.PrepareUserViewModel(user);
                    return Ok(userResult); 
                } 
            } 
            catch (Exception ex) 
            { 
                _log.Error($"Something went wrong inside GetOwnerById action: {ex.Message}"); 
                return StatusCode(500, "Internal server error"); 
            } 
        }

        /// <summary>
        /// Method to register user details in database with validation
        /// </summary>
        /// <param name="userRegisterModel"> User details object to save user</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RegisterUser([FromBody]UserRegisterModel userRegisterModel)
        {
            try
            {
                if (userRegisterModel == null)
                {
                    _log.Error("User object sent from client is null.");
                    return BadRequest("User object is null");
                }

                if (!ModelState.IsValid)
                {
                    _log.Error("Invalid User object sent from client.");
                    return BadRequest("Invalid User object");
                }

                var userEntity = this._usermodelfactory.PrepareUserRegisterModel(userRegisterModel);
                this._repository.User.CreateUser(userEntity);
                this._repository.Save();
                var _response = JsonConvert.SerializeObject(new
                {
                    Response = new { Success = "True", status = HttpStatusCode.OK, message = "Data Inserted Successfully", statusCode = HttpStatusCode.OK, stack = "" }
                });

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _log.Error($"Something went wrong inside RegisterUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Method to update user details by user id
        /// </summary>
        /// <param name="userUpdateModel"> User details object to update user</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateUser([FromBody]UserUpdateModel userUpdateModel)
        {
            try
            {
                if (userUpdateModel == null)
                {
                    _log.Error("User object sent from client is null.");
                    return BadRequest("User object is null");
                }
                if (!ModelState.IsValid)
                {
                    _log.Error("Invalid user object sent from client.");
                    return BadRequest("Invalid user object");
                }
                var userEntity = this._repository.User.GetUserById(userUpdateModel.Id);
                if (userEntity == null)
                {
                    _log.Error($"User with id: {userUpdateModel.Id}, hasn't been found in db.");
                    return NotFound();
                }
                this._mapper.Map(userUpdateModel, userEntity);
                userEntity.UpdatedOn = DateTime.Now;
                this._repository.User.UpdateUser(userEntity);
                this._repository.Save();
                var _response = JsonConvert.SerializeObject(new
                {
                    Response = new { Success = "True", status = HttpStatusCode.OK, message = "Data Updated Successfully", statusCode = HttpStatusCode.OK, stack = "" }
                });
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _log.Error($"Something went wrong inside UpdateUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Method to delete user record by user id
        /// </summary>
        /// <param name="id"> user id to delete user against this id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Int64 id)
        {
            try
            {
                var user = this._repository.User.GetUserById(id);
                if (user == null)
                {
                    _log.Error($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                user.IsDeleted = true;
                user.UpdatedOn = DateTime.Now;
                this._repository.User.UpdateUser(user);
                //this._repository.User.DeleteUser(user);
                this._repository.Save();
                var _response = JsonConvert.SerializeObject(new
                {
                    Response = new { Success = "True", status = HttpStatusCode.OK, message = "Data Deleted Successfully", statusCode = HttpStatusCode.OK, stack = "" }
                });
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _log.Error($"Something went wrong inside DeleteUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        #endregion
    }
}