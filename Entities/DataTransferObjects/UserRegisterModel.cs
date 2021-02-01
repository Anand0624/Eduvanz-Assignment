using Entities.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class UserRegisterModel
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        [JsonProperty("name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name can't be longer than 20 characters")]
        public string Name { get; set; }

        /// <summary>
        /// Age of the User
        /// </summary>
        [JsonProperty("age")]
        [Required(ErrorMessage = "Age is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Age should be numeric")]
        public string Age { get; set; }

        /// <summary>
        /// User date of birth in YYYY-MM-DD format
        /// </summary>
        [JsonProperty("dateofbirth")]
        [Required(ErrorMessage = "Date of birth is required")]
        [ValidateDate(ErrorMessage = "Date of birth is not valid")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Profession of user
        /// </summary>
        [JsonProperty("profession")]
        [Required(ErrorMessage = "Profession is required")]
        [StringLength(10, ErrorMessage = "Profession can't be longer than 10 characters")]
        public string Profession { get; set; }

        /// <summary>
        /// Locality of user
        /// </summary>
        [JsonProperty("locality")]
        [Required(ErrorMessage = "Locality is required")]
        [StringLength(20, ErrorMessage = "Locality can't be longer than 20 characters")]
        public string Locality { get; set; }

        /// <summary>
        /// No of guest can allow with user, Note : Max 2 guest are allowed
        /// </summary>
        [JsonProperty("noofguest")]
        [Required(ErrorMessage = "No of guest is required")]
        [Range(0, 2, ErrorMessage = "only 0 to 2 guest allowed")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "no of guest should be numeric")]
        public string NoOfGuest { get; set; }

        /// <summary>
        /// User address
        /// </summary>
        [JsonProperty("address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(50, ErrorMessage = "Address cannot be loner then 50 characters")]
        public string Address { get; set; }
       
    }
}
