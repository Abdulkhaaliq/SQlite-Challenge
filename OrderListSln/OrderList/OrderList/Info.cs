using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace OrderListdatabase
{
    public class Info
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public DateTime DateOrdered { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
