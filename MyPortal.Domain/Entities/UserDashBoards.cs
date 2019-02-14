using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Core.Entities
{
    public class UserDashBoards
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DashboardId { get; set; }

        public User User { get; set; }
        public Dashboard Dashboard { get; set; }
    }
}
