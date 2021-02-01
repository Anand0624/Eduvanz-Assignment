using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("tbl_meetup")] 
    public class RegisterUser 
    { 
        [Column("Id")]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public Int64 Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Profession { get; set; }
        public string Locality { get; set; }
        public Int64 NoOfGuest { get; set; }
        public string Address { get; set; }
        public Boolean IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }


    }
}
