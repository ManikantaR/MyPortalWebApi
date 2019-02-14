using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortal.WebApi.Models
{
    public class UserWithDashBoards
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<DashBoardDto> DashBoards { get; set; }
    }
}
