
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionElement+ColorDriver
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.IField<UnityEngine.ColorX> ColorDrive { get => ColorDrive_Element.Data; set => ColorDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> ColorDrive_Element = new();
public global::FrooxEngine.UIX.InteractionElement.ColorMode TintColorMode { get => TintColorMode_Element.Data; set => TintColorMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UIX.InteractionElement.ColorMode>, global::FrooxEngine.UIX.InteractionElement.ColorMode> TintColorMode_Element = new();
public UnityEngine.ColorX NormalColor { get => NormalColor_Element.Data; set => NormalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NormalColor_Element = new();
public UnityEngine.ColorX HighlightColor { get => HighlightColor_Element.Data; set => HighlightColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> HighlightColor_Element = new();
public UnityEngine.ColorX PressColor { get => PressColor_Element.Data; set => PressColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PressColor_Element = new();
public UnityEngine.ColorX DisabledColor { get => DisabledColor_Element.Data; set => DisabledColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> DisabledColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ColorDrive", ColorDrive_Element.ToLinkReference(context));
members.Add("TintColorMode", TintColorMode_Element.ToLinkField(context));
members.Add("NormalColor", NormalColor_Element.ToLinkField(context));
members.Add("HighlightColor", HighlightColor_Element.ToLinkField(context));
members.Add("PressColor", PressColor_Element.ToLinkField(context));
members.Add("DisabledColor", DisabledColor_Element.ToLinkField(context));
}

}
            }
}
