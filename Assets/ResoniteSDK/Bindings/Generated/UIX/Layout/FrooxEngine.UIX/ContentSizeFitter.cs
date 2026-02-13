
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ContentSizeFitter
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HorizontalFit", HorizontalFit.ToResoniteLinkField());
members.Add("VerticalFit", VerticalFit.ToResoniteLinkField());
}

}
}
