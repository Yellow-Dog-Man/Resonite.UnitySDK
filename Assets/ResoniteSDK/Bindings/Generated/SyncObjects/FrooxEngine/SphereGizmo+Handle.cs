
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SphereGizmo+Handle
// Generated on: pátek 13. února 2026 5:52:30
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RelativeRadius", RelativeRadius.ToResoniteLinkField());
members.Add("root", new ResoniteLink.Reference() { });
members.Add("mesh", new ResoniteLink.Reference() { });
}

}
            }
}
