using MenuBuilder.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MenuBuilder();
            builder
                .AddLeaf("Leaf 1")
                .AddLeaf("Leaf 2")
                .AddLeaf("Leaf 3")
                .AddBranch("Branch 1")
                    .AddLeaf("Leaf 1")
                    .AddLeaf("Leaf 2")
                    .Bulid()
                .AddLeaf("Leaf 4");

            foreach (var menu in builder.Roots)
            {
                PrintMenu(menu);
            }
            Console.ReadLine();
        }

        static void PrintMenu(Menu menu, int spacing = 0)
        {
            var subMenu = menu as ISubMenuHolder;
            Enumerable.Range(0, spacing).ToList().ForEach(x => Console.Write("\t|"));
            Console.WriteLine("---> {0}", menu.Name);
            spacing +=1;
            if(subMenu != null && subMenu.SubMenus.Any())
                subMenu.SubMenus.ForEach(x => PrintMenu(x, spacing));
        }
    }
}
