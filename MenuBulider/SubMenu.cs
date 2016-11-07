using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public abstract class SubMenu : Menu
    {
        public Guid ParentId { get; set; }
    }
}
