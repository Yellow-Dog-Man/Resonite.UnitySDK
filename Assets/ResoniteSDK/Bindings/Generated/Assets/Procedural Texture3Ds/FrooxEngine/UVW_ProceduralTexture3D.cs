
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVW_ProceduralTexture3D
// Generated on: pátek 13. února 2026 23:21:36
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UVW_ProceduralTexture3D")]
public partial class UVW_ProceduralTexture3D : global::FrooxEngine.ProceduralTexture3D

{
    public UnityEngine.Vector3 ValueOffset;
public UnityEngine.Vector3 ValueMultiplier;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ValueOffset", ValueOffset.ToResoniteLinkField());
members.Add("ValueMultiplier", ValueMultiplier.ToResoniteLinkField());
}

}
}
