
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectSizeDriver
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectSizeDriver")]
public partial class RectSizeDriver : global::FrooxEngine.UIX.UIController

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> TargetSize;
public UnityEngine.Vector2 Scale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSize", TargetSize.ToResoniteReference(context));
members.Add("Scale", Scale.ToResoniteLinkField());
}

}
}
