
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeUnlitMaterial+SlicePlane
// Generated on: pátek 13. února 2026 23:21:34
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
    public partial class VolumeUnlitMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeUnlitMaterial+SlicePlane")]
public partial class SlicePlane : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Normal;
public global::System.Single Offset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
}

}
            }
}
