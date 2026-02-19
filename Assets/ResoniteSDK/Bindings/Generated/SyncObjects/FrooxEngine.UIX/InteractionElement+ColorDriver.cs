
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionElement+ColorDriver
// Generated on: čtvrtek 19. února 2026 7:58:55
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
    public partial class InteractionElement
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.InteractionElement+ColorDriver")]
public partial class ColorDriver : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> ColorDrive;
public global::FrooxEngine.UIX.InteractionElement.ColorMode TintColorMode;
public UnityEngine.ColorX NormalColor;
public UnityEngine.ColorX HighlightColor;
public UnityEngine.ColorX PressColor;
public UnityEngine.ColorX DisabledColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ColorDrive", ColorDrive.ToResoniteReference(context));
members.Add("TintColorMode", TintColorMode.ToResoniteLinkField());
members.Add("NormalColor", NormalColor.ToResoniteLinkField());
members.Add("HighlightColor", HighlightColor.ToResoniteLinkField());
members.Add("PressColor", PressColor.ToResoniteLinkField());
members.Add("DisabledColor", DisabledColor.ToResoniteLinkField());
}

}
            }
}
