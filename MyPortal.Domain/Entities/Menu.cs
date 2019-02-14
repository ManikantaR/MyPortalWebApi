using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? ParentMenuId { get; set; }
        public Menu ParentMenu { get; set; }

        public IEnumerable<Menu> SubMenus { get; set; }       

    }
}
