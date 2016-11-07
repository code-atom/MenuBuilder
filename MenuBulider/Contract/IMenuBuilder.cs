using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Contract
{
    public interface IMenuBuilder
    {
        List<Menu> Roots { get; }
        IMenuBuilder AddLeaf(string name);
        IMenuBuilder AddBranch(string name);
        IMenuBuilder Bulid();
    }
}
