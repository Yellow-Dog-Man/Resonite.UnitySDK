using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FrooxEngine;

public static class ComponentHelper
{
    public static void SetFrom(this ComponentBase<FrooxEngine.Component> resonite, UnityEngine.Behaviour unity)
    {
        // Unity doens't have a same concept of persistence, so just leave it to be true
        resonite.persistent = true;

        // Straight up copy
        resonite.Enabled = unity.enabled;

        // TODO!!!
        // UpdateOrder? Fetch from Unity? It might not quite map.
    }
}
