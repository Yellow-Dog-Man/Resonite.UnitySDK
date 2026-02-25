
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.GradientImage
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.GradientImage")]
public partial class GradientImage : global::FrooxEngine.UIX.ImageBase

{
    public UnityEngine.ColorX TintTopLeft;
public UnityEngine.ColorX TintTopRight;
public UnityEngine.ColorX TintBottomRight;
public UnityEngine.ColorX TintBottomLeft;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TintTopLeft", TintTopLeft.ToResoniteLinkField());
members.Add("TintTopRight", TintTopRight.ToResoniteLinkField());
members.Add("TintBottomRight", TintBottomRight.ToResoniteLinkField());
members.Add("TintBottomLeft", TintBottomLeft.ToResoniteLinkField());
}

}
}
