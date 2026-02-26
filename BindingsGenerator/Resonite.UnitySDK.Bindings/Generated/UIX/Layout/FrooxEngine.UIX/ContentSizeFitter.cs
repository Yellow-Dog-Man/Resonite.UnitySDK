
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ContentSizeFitter
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UIX.SizeFit HorizontalFit { get => HorizontalFit_Element.Data; set => HorizontalFit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.SizeFit>, global::FrooxEngine.UIX.SizeFit> HorizontalFit_Element = new();
public global::FrooxEngine.UIX.SizeFit VerticalFit { get => VerticalFit_Element.Data; set => VerticalFit_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.SizeFit>, global::FrooxEngine.UIX.SizeFit> VerticalFit_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HorizontalFit", HorizontalFit_Element.ToLinkField(context));
members.Add("VerticalFit", VerticalFit_Element.ToLinkField(context));
}

}
}
