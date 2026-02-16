using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class MeshCollider
    {
        public void SetFrom(UnityEngine.MeshCollider collider, IConversionContext context)
        {
            if (collider.convex)
                throw new System.InvalidOperationException($"Unity mesh collider is convex. You need to use ConvexHullCollider instead");

            base.SetFrom(collider);

            Mesh = context.GetMesh(collider.sharedMesh);

            // Unity Mesh Colliders are one-sided based on their documentation:
            // https://docs.unity3d.com/6000.3/Documentation/Manual/mesh-colliders-introduction.html
            Sidedness = MeshColliderSidedness.Front;
        }
    }

    public partial class ConvexHullCollider
    {
        public void SetFrom(UnityEngine.MeshCollider collider, IConversionContext context)
        {
            if (!collider.convex)
                throw new System.InvalidOperationException($"Unity mesh collider not is convex. You need to use ConvexHullCollider instead");

            base.SetFrom(collider);

            Mesh = context.GetMesh(collider.sharedMesh);
        }
    }
}

public class MeshColliderConverter : ResoniteComponentConverter<UnityEngine.MeshCollider>
{
    public MeshColliderWrapper MeshBinding;
    public ConvexHullColliderWrapper ConvexHullBinding;

    protected override void UpdateConversion(UnityEngine.MeshCollider target, IConversionContext context)
    {
        // Resonite represents Convex Hull & Mesh Colliders through separate components, rather than one with a toggle
        // We need to swith between them appropriately based on the flag whenever we update this.
        if(target.convex)
        {
            if (MeshBinding != null)
                DestroyImmediate(MeshBinding);

            if (ConvexHullBinding == null)
                ConvexHullBinding = gameObject.AddComponent<ConvexHullColliderWrapper>();

            ConvexHullBinding.Data.SetFrom(target, context);
        }
        else
        {
            if (ConvexHullBinding != null)
                DestroyImmediate(ConvexHullBinding);

            if (MeshBinding == null)
                MeshBinding = gameObject.AddComponent<MeshColliderWrapper>();

            MeshBinding.Data.SetFrom(target, context);
        }
    }

    protected override void Cleanup()
    {
        if (MeshBinding != null)
            DestroyImmediate(MeshBinding);

        if (ConvexHullBinding != null)
            DestroyImmediate(ConvexHullBinding);
    }
}
