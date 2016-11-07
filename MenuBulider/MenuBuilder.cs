using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.Contract;

namespace MenuBuilder
{
    public class MenuBuilder : IMenuBuilder
    {
        public List<Menu> Roots { get; private set; }
        private readonly IMenuBuilder builder = null;
        private readonly ISubMenuHolder parentMenu = null;

        public MenuBuilder()
        {
            Roots = new List<Menu>();
        }

        public MenuBuilder(IMenuBuilder builder, ISubMenuHolder parentMenu)
        {
            this.builder = builder;
            this.parentMenu = parentMenu;
        }

        public IMenuBuilder AddLeaf(string name)
        {
            if(parentMenu != null)
            {
                var menu = new BranchLeafMenu { Name = name, ParentId = (parentMenu as Menu).Id };
                parentMenu.AddSubmenu(menu);
            }
            else
            {
                var  menu = new RootLeafMenu { Name = name };
                Roots.Add(menu);
            }
            return this;    
        }

        public IMenuBuilder AddBranch(string name)
        {
            if (parentMenu != null)
            {
                var menu = new ChildBranchMenu { Name = name, ParentId = (parentMenu as Menu).Id };
                parentMenu.AddSubmenu(menu);
                return new MenuBuilder(this, menu);
            }
            else
            {
                var menu = new RootBranchMenu { Name = name };
                Roots.Add(menu);
                return new MenuBuilder(this, menu);
            }
        }

        public IMenuBuilder Bulid()
        {
            return builder ?? this;
        }
    }
}
