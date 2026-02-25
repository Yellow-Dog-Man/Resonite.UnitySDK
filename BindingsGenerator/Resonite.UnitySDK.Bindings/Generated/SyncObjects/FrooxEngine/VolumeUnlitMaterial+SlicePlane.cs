
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeUnlitMaterial+SlicePlane
// Generated on: středa 25. února 2026 16:13:04
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
    public partial class VolumeUnlitMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeUnlitMaterial+SlicePlane")]
public partial class SlicePlane : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Normal;
public global::System.Single Offset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("Offset", Offset.ToResoniteLinkField());
}

}
            }
}
