
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionElement
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.InteractionElement")]
public abstract partial class InteractionElement : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public UnityEngine.ColorX BaseColor;
public System.Collections.Generic.List<global::FrooxEngine.UIX.InteractionElement.ColorDriver> ColorDrivers;
public UnityEngine.ColorX __legacy_NormalColor;
public UnityEngine.ColorX __legacy_HighlightColor;
public UnityEngine.ColorX __legacy_PressColor;
public UnityEngine.ColorX __legacy_DisabledColor;
public global::FrooxEngine.UIX.InteractionElement.ColorMode __legacy_TintColorMode;
public global::FrooxEngine.IField<UnityEngine.ColorX> __legacy_ColorDrive;
public global::System.Boolean IsPressed;
public global::System.Boolean IsHovering;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("ColorDrivers", new ResoniteLink.SyncList()
{
    Elements = ColorDrivers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("__legacy_NormalColor", __legacy_NormalColor.ToResoniteLinkField());
members.Add("__legacy_HighlightColor", __legacy_HighlightColor.ToResoniteLinkField());
members.Add("__legacy_PressColor", __legacy_PressColor.ToResoniteLinkField());
members.Add("__legacy_DisabledColor", __legacy_DisabledColor.ToResoniteLinkField());
members.Add("__legacy_TintColorMode", __legacy_TintColorMode.ToResoniteLinkField());
members.Add("__legacy_ColorDrive", __legacy_ColorDrive.ToResoniteReference(context));
members.Add("IsPressed", IsPressed.ToResoniteLinkField());
members.Add("IsHovering", IsHovering.ToResoniteLinkField());
}

}
}
