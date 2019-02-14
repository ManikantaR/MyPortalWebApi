using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Core.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
