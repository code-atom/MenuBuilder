using MenuBuilder.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class RootBranchMenu : Menu, ISubMenuHolder
    {
        public RootBranchMenu()
        {
            SubMenus = new List<SubMenu>();
        }

        public List<SubMenu> SubMenus
        {
            get;
            private set;
        }

        public void AddSubmenu(SubMenu menu)
        {
            SubMenus.Add(menu);
        }
    }

    public class ChildBranchMenu : SubMenu, ISubMenuHolder
    {
        public ChildBranchMenu()
        {
            SubMenus = new List<SubMenu>();
        }
        public List<SubMenu> SubMenus
        {
            get;
            private set;
        }

        public void AddSubmenu(SubMenu menu)
        {
            SubMenus.Add(menu);
        }
    }
}
