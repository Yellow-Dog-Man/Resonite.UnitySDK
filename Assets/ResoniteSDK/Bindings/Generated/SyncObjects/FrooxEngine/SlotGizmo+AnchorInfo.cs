
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotGizmo+AnchorInfo
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("anchor", new ResoniteLink.Reference() { });
members.Add("posDrive", new ResoniteLink.Reference() { });
members.Add("scaleDrive", new ResoniteLink.Reference() { });
}

}
            }
}
