
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserItem
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrowserItem")]
public abstract partial class BrowserItem : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.BrowserDialog Browser { get => Browser_Element.Data; set => Browser_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.BrowserDialog>, global::FrooxEngine.BrowserDialog> Browser_Element = new();
public UnityEngine.ColorX SelectedColor { get => SelectedColor_Element.Data; set => SelectedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SelectedColor_Element = new();
public UnityEngine.ColorX SelectedText { get => SelectedText_Element.Data; set => SelectedText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SelectedText_Element = new();
public UnityEngine.ColorX NormalColor { get => NormalColor_Element.Data; set => NormalColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NormalColor_Element = new();
public UnityEngine.ColorX NormalText { get => NormalText_Element.Data; set => NormalText_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NormalText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Browser", Browser_Element.ToLinkReference(context));
members.Add("SelectedColor", SelectedColor_Element.ToLinkField(context));
members.Add("SelectedText", SelectedText_Element.ToLinkField(context));
members.Add("NormalColor", NormalColor_Element.ToLinkField(context));
members.Add("NormalText", NormalText_Element.ToLinkField(context));
}

}
}
