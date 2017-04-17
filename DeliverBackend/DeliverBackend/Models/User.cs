using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeliverBackend.Models
{
    public class Rol : BaseModel
    {
        public string Description { get; set; }
    }


    public class User : BaseModel
    {
        [Key]
        [Column(Order = 1)]
        public string RolId { get; set; }

        public string Name { get; set; }

        public string Surnames { get; set; }

        public string Photo { get; set; }

        public DateTime BirthdayDate { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Points { get; set; }

        // public virtual Rol Rol { get; set; }

        //public ICollection<Card> Cards { get; set; }

    }

    public class Address : BaseModel
    {
        public string UserId { get; set; }

        public string Description { get; set; }
    }
}