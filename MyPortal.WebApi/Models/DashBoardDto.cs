using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortal.WebApi.Models
{
    public class DashBoardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }

    public class CreateDashBoard
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }


}
