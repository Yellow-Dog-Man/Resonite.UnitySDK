using System;
using System.Collections.Generic;
using System.Text;

namespace FrooxEngine
{
    public partial class ComponentBase<C>
    {
        public ComponentBase()
        {
            // Some sane defaults
            persistent = true;
            Enabled = true;
        }
    }
}