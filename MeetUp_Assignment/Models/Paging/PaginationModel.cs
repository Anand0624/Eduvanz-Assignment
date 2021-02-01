using Entities.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetUp_Assignment.Models.Paging
{
    public class PaginationModel : PageModel
    {
        /// <summary>
        /// Set current page of pagination
        /// </summary>
        public int CurrentPage { get; set; } =1;
        /// <summary>
        /// total no of record count set
        /// </summary>
        public Int64 Count { get; set; }
        /// <summary>
        /// default pageSize for pagination
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// calculate no of  pages devide by total count
        /// </summary>
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        /// <summary>
        /// User data from database
        /// </summary>
        public List<RegisterUser> UserData { get; set; }
        /// <summary>
        /// show previous pagination page  button on current page number
        /// </summary>
        public bool ShowPrevious => CurrentPage > 1;
        /// <summary>
        /// show next pagination page button on current page number
        /// </summary>
        public bool ShowNext => CurrentPage < TotalPages;
    }
}
