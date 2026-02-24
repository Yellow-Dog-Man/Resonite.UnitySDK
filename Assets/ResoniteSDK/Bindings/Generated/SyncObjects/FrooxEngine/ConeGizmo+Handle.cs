
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeGizmo+Handle
// Generated on: úterý 24. února 2026 18:20:19
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class ConeGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConeGizmo+Handle")]
public partial class Handle : global::FrooxEngine.SyncObject

{
    public global::System.Single RelativeHeight;
public global::FrooxEngine.Slot root;
public global::FrooxEngine.IField<UnityEngine.Vector3> offset;
public global::FrooxEngine.TorusMesh mesh;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelativeHeight", RelativeHeight.ToResoniteLinkField());
members.Add("root", root.ToResoniteReference(context));
members.Add("offset", offset.ToResoniteReference(context));
members.Add("mesh", mesh.ToResoniteReference(context));
}

}
            }
}
