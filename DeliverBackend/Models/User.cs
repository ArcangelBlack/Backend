using Microsoft.Azure.Mobile.Server;

namespace DeliverBackend.Models
{
    public class User : EntityData
    {
        public string RolId { get; set; }

        public string Name { get; set; }

        public string Surnames { get; set; }
    }
}