using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public abstract partial class Collider<TShape>
    {
        public void SetFrom(UnityEngine.Collider collider)
        {
            persistent = true;
            Enabled = collider.enabled;

            if (collider.isTrigger)
            {
                Type = ColliderType.Trigger;
                CharacterCollider = false;
            }
            else
            {
                Type = ColliderType.Static;
                CharacterCollider = true;
            }
        }
    }
}