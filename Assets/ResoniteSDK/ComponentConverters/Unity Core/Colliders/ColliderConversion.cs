using FrooxEngine;

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