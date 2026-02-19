
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVW_ProceduralTexture3D
// Generated on: čtvrtek 19. února 2026 7:58:54
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UVW_ProceduralTexture3D")]
public partial class UVW_ProceduralTexture3D : global::FrooxEngine.ProceduralTexture3D

{
    public UnityEngine.Vector3 ValueOffset;
public UnityEngine.Vector3 ValueMultiplier;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ValueOffset", ValueOffset.ToResoniteLinkField());
members.Add("ValueMultiplier", ValueMultiplier.ToResoniteLinkField());
}

}
}
