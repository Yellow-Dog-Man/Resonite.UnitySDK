
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionElement
// Generated on: čtvrtek 26. února 2026 15:07:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.InteractionElement")]
public abstract partial class InteractionElement : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UIX.InteractionElement.ColorDriver>, global::FrooxEngine.UIX.InteractionElement.ColorDriver> ColorDrivers = new();
public UnityEngine.ColorX __legacy_NormalColor { get => __legacy_NormalColor_Element.Data; set => __legacy_NormalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> __legacy_NormalColor_Element = new();
public UnityEngine.ColorX __legacy_HighlightColor { get => __legacy_HighlightColor_Element.Data; set => __legacy_HighlightColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> __legacy_HighlightColor_Element = new();
public UnityEngine.ColorX __legacy_PressColor { get => __legacy_PressColor_Element.Data; set => __legacy_PressColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> __legacy_PressColor_Element = new();
public UnityEngine.ColorX __legacy_DisabledColor { get => __legacy_DisabledColor_Element.Data; set => __legacy_DisabledColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> __legacy_DisabledColor_Element = new();
public global::FrooxEngine.UIX.InteractionElement.ColorMode __legacy_TintColorMode { get => __legacy_TintColorMode_Element.Data; set => __legacy_TintColorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.InteractionElement.ColorMode>, global::FrooxEngine.UIX.InteractionElement.ColorMode> __legacy_TintColorMode_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> __legacy_ColorDrive { get => __legacy_ColorDrive_Element.Data; set => __legacy_ColorDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> __legacy_ColorDrive_Element = new();
public global::System.Boolean IsPressed { get => IsPressed_Element.Data; set => IsPressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPressed_Element = new();
public global::System.Boolean IsHovering { get => IsHovering_Element.Data; set => IsHovering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsHovering_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor_Element.ToLinkField(context));
members.Add("ColorDrivers", ColorDrivers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("__legacy_NormalColor", __legacy_NormalColor_Element.ToLinkField(context));
members.Add("__legacy_HighlightColor", __legacy_HighlightColor_Element.ToLinkField(context));
members.Add("__legacy_PressColor", __legacy_PressColor_Element.ToLinkField(context));
members.Add("__legacy_DisabledColor", __legacy_DisabledColor_Element.ToLinkField(context));
members.Add("__legacy_TintColorMode", __legacy_TintColorMode_Element.ToLinkField(context));
members.Add("__legacy_ColorDrive", __legacy_ColorDrive_Element.ToLinkReference(context));
members.Add("IsPressed", IsPressed_Element.ToLinkField(context));
members.Add("IsHovering", IsHovering_Element.ToLinkField(context));
}

}
}
