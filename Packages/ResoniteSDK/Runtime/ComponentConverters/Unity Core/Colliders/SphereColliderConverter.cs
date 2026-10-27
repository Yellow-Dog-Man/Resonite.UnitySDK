using UnityEngine;

namespace ResoniteSDK {
    public static class SphereColliderHelper
    {
        public static void SetFrom(this FrooxEngine.SphereCollider resonite, UnityEngine.SphereCollider unity)
        {
            // Set the base data
            resonite.SetFrom((UnityEngine.Collider)unity);

            resonite.Radius = unity.radius;
            resonite.Offset = unity.center;
        }
    }

    public class SphereColliderConverter : ResoniteSingleComponentConverter<SphereCollider, FrooxEngine.SphereCollider>
    {
        protected override void UpdateConversion(SphereCollider target, IConversionContext context)
        {
            Binding.SetFrom(target);
        }
    }
}