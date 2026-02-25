using FrooxEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ColliderHelper
{
    public static void SetFrom<TShape>(this FrooxEngine.Collider<TShape> resonite, UnityEngine.Collider unity)
         where TShape : struct
    {
        resonite.persistent = true;
        resonite.Enabled = unity.enabled;

        if (unity.isTrigger)
        {
            resonite.Type = ColliderType.Trigger;
            resonite.CharacterCollider = false;
        }
        else
        {
            resonite.Type = ColliderType.Static;
            resonite.CharacterCollider = true;
        }
    }
}