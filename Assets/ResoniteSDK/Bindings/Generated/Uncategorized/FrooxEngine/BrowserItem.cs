
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserItem
// Generated on: úterý 24. února 2026 18:20:19
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.BrowserDialog Browser;
public UnityEngine.ColorX SelectedColor;
public UnityEngine.ColorX SelectedText;
public UnityEngine.ColorX NormalColor;
public UnityEngine.ColorX NormalText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Browser", Browser.ToResoniteReference(context));
members.Add("SelectedColor", SelectedColor.ToResoniteLinkField());
members.Add("SelectedText", SelectedText.ToResoniteLinkField());
members.Add("NormalColor", NormalColor.ToResoniteLinkField());
members.Add("NormalText", NormalText.ToResoniteLinkField());
}

}
}
