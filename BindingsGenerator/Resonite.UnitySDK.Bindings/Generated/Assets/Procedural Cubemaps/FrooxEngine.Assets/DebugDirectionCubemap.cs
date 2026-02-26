
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Assets.DebugDirectionCubemap
// Generated on: čtvrtek 26. února 2026 10:03:35
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Assets.DebugDirectionCubemap")]
public partial class DebugDirectionCubemap : global::FrooxEngine.ProceduralCubemap

{
    public UnityEngine.Vector3Bool RGB_Mask { get => RGB_Mask_Element.Data; set => RGB_Mask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Bool>, UnityEngine.Vector3Bool> RGB_Mask_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RGB_Mask", RGB_Mask_Element.Data.ToResoniteLinkField());
}

}
}
