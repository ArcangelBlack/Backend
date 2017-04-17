using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#if SERVICE
using Microsoft.Azure.Mobile.Server.Tables;

#endif

namespace DeliverBackend.Models
{
    public class BaseModel
#if SERVICE
        : ITableData
#endif
    {
        //public BaseModel()
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}

        [Key]
        [Column(Order = 0)]
        public string Id { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}