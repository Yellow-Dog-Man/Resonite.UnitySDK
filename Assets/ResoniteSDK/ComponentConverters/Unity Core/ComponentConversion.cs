using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public abstract partial class ComponentBase<C>
    {
        public void SetFrom(UnityEngine.Behaviour component)
        {
            // Unity doens't have a same concept of persistence, so just leave it to be true
            persistent = true;

            // Straight up copy
            Enabled = component.enabled;

            // TODO!!!
            // UpdateOrder? Fetch from Unity? It might not quite map.
        }
    }
}
