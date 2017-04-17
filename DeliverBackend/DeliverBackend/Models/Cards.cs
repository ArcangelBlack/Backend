using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliverBackend.Models
{
    public class Card : BaseModel
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public string Name { get; set; }

        //[Index("Card_Number_Index", IsUnique = true)]
        public long Number { get; set; }

        public int Cvv { get; set; }

        public DateTime ExpirationDate { get; set; }

       // public virtual User User { get; set; }

    }
}