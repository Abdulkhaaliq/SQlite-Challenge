using System;
using System.ComponentModel.DataAnnotations;

namespace TShirtApi.Api.Models
{
    public class Info
    {

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Size { get; set; }

        public DateTime Date{ get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
