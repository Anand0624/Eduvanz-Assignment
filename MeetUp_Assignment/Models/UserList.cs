using Entities.Models;
using MeetUp_Assignment.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetUp_Assignment.Models
{
    public class UserList : RegisterUser
    {
        public UserList()
        {
            paginationModel = new PaginationModel();
        }
        public PaginationModel paginationModel { get; set; }
        public string SearchName { get; set; }
        public string SearchLocality { get; set; }
    }
}
