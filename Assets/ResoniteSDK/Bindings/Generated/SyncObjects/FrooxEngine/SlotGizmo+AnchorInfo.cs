
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo+AnchorInfo
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class SlotGizmo
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotGizmo+AnchorInfo")]
public partial class AnchorInfo : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.PointAnchor anchor;
public global::FrooxEngine.IField<UnityEngine.Vector3> posDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> scaleDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("anchor", anchor.ToResoniteReference(context));
members.Add("posDrive", posDrive.ToResoniteReference(context));
members.Add("scaleDrive", scaleDrive.ToResoniteReference(context));
}

}
            }
}
