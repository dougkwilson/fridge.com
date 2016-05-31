using System;
using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class FridgeRequestModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public String Data { get; set; }

        [OptionalEmailAddress]
        [StringLength(100)]
        public String Email { get; set; }
    }

    public class FridgeResponseModel
    {
        public Boolean Failed { get; set; }
    }
}