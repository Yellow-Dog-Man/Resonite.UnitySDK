
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVW_ProceduralTexture3D
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public UnityEngine.Vector3 ValueOffset { get => ValueOffset_Element.Data; set => ValueOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ValueOffset_Element = new();
public UnityEngine.Vector3 ValueMultiplier { get => ValueMultiplier_Element.Data; set => ValueMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ValueMultiplier_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ValueOffset", ValueOffset_Element.ToLinkField(context));
members.Add("ValueMultiplier", ValueMultiplier_Element.ToLinkField(context));
}

}
}
