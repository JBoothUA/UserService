using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace TandemUserService
{
    public class TandemUser
    {
        //jeb [JsonProperty("id")]
        //public Guid UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
