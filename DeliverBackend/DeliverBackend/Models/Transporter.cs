using System;
using System.ComponentModel.DataAnnotations;

namespace DeliverBackend.Models
{
    public class Transporter : BaseModel
    {
        public string Name { get; set; }

        public string Surnames { get; set; }

        public string Photo { get; set; }

        public DateTime BirthdayDate { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Points { get; set; }

    }

    public class Mobile : BaseModel
    {
        public int MobileType { get; set; }

        public string TransporterId { get; set; }

        public string Description { get; set; }
    }
}