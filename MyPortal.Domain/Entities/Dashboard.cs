using System;
using System.Collections.Generic;

namespace MyPortal.Core.Entities
{
    public class Dashboard
    {

        public Dashboard()
        {
            DashboardUsers = new HashSet<UserDashBoards>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedOn { get; set; }

        
        public IEnumerable<UserDashBoards> DashboardUsers { get; set; }
    }
}