
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionElement+ColorDriver
// Generated on: pátek 13. února 2026 5:51:10
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ColorDrive", new ResoniteLink.Reference() { });
members.Add("TintColorMode", TintColorMode.ToResoniteLinkField());
members.Add("NormalColor", NormalColor.ToResoniteLinkField());
members.Add("HighlightColor", HighlightColor.ToResoniteLinkField());
members.Add("PressColor", PressColor.ToResoniteLinkField());
members.Add("DisabledColor", DisabledColor.ToResoniteLinkField());
}

}
            }
}
