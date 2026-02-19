
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransformLerp
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectTransformLerp")]
public partial class RectTransformLerp : global::FrooxEngine.UIX.UIController

{
    public global::System.Single Lerp;
public global::FrooxEngine.UIX.RectTransform SourceRect;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp.ToResoniteLinkField());
members.Add("SourceRect", SourceRect.ToResoniteReference(context));
}

}
}
