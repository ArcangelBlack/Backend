using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace DeliverBackend.Models
{
    public class Card : EntityData
    {
        public string Name { get; set; }
    }
}