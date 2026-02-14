
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Assets.DebugDirectionCubemap
// Generated on: sobota 14. února 2026 8:56:59
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.Vector3Bool RGB_Mask;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RGB_Mask", RGB_Mask.ToResoniteLinkField());
}

}
}
