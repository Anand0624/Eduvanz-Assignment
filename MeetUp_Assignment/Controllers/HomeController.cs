using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using MeetUp.Services;
using MeetUp_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetUp_Assignment.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private readonly IRepositoryWrapper _repository;
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Constructor
        public HomeController(IRepositoryWrapper repository)
        {
            this._repository = repository;
        }
        #endregion
        public IActionResult Index(int currentPage = 1, UserList objUserList=null)
        {
            if (objUserList == null)
                objUserList = new UserList();
            var owners = this._repository.User.GetAllUsersWithSearch(currentPage, objUserList.paginationModel.PageSize,out int count, objUserList.SearchName,objUserList.SearchLocality);
            objUserList.paginationModel.UserData = owners;
            objUserList.paginationModel.Count = count;
            objUserList.paginationModel.CurrentPage = currentPage;
            _log.Info($"Returned all users from database.");
            return View(objUserList);
        }
    }
}