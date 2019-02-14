using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Core.Entities
{
    public class User
    {
        public User()
        {
            Dashboards = new HashSet<Dashboard>();
            UserDashboards = new HashSet<UserDashBoards>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Phone { get; set; }

        public ICollection<Dashboard> Dashboards { get; set; }
        public ICollection<UserDashBoards> UserDashboards { get; set; }

        public void AddDashBoards(List<Dashboard> dashboards){

            dashboards.ForEach(a => Dashboards.Add(a));
}


    }
}
