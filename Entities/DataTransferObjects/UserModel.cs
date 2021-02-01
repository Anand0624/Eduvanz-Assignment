using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserModel
    {
        public Int64 Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string DateOfBirth { get; set; }

        public string Profession { get; set; }

        public string Locality { get; set; }

        public string NoOfGuest { get; set; }

        public string Address { get; set; }

        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }

    }
}
