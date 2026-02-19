
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ContentSizeFitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ContentSizeFitter")]
public partial class ContentSizeFitter : global::FrooxEngine.UIX.UIComputeComponent, global::FrooxEngine.UIX.ILayoutElement

{
    public global::FrooxEngine.UIX.SizeFit HorizontalFit;
public global::FrooxEngine.UIX.SizeFit VerticalFit;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HorizontalFit", HorizontalFit.ToResoniteLinkField());
members.Add("VerticalFit", VerticalFit.ToResoniteLinkField());
}

}
}
