using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Contract
{
    public interface ISubMenuHolder
    {
        List<SubMenu> SubMenus { get; }
        void AddSubmenu(SubMenu menu);
    }
}
