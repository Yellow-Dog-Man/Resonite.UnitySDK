
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo+Handle
// Generated on: středa 25. února 2026 16:14:37
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class SphereGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SphereGizmo+Handle")]
public partial class Handle : global::FrooxEngine.SyncObject

{
    public global::System.Single RelativeRadius;
public global::FrooxEngine.Slot root;
public global::FrooxEngine.TorusMesh mesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeRadius", RelativeRadius.ToResoniteLinkField());
members.Add("root", root.ToResoniteReference(context));
members.Add("mesh", mesh.ToResoniteReference(context));
}

}
            }
}
