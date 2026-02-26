
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransform
// Generated on: čtvrtek 26. února 2026 12:26:55
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectTransform")]
public partial class RectTransform : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public UnityEngine.Vector2 AnchorMin { get => AnchorMin_Element.Data; set => AnchorMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AnchorMin_Element = new();
public UnityEngine.Vector2 AnchorMax { get => AnchorMax_Element.Data; set => AnchorMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AnchorMax_Element = new();
public UnityEngine.Vector2 OffsetMin { get => OffsetMin_Element.Data; set => OffsetMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetMin_Element = new();
public UnityEngine.Vector2 OffsetMax { get => OffsetMax_Element.Data; set => OffsetMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OffsetMax_Element = new();
public UnityEngine.Vector2 Pivot { get => Pivot_Element.Data; set => Pivot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Pivot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AnchorMin", AnchorMin_Element.ToLinkField(context));
members.Add("AnchorMax", AnchorMax_Element.ToLinkField(context));
members.Add("OffsetMin", OffsetMin_Element.ToLinkField(context));
members.Add("OffsetMax", OffsetMax_Element.ToLinkField(context));
members.Add("Pivot", Pivot_Element.ToLinkField(context));
}

}
}
