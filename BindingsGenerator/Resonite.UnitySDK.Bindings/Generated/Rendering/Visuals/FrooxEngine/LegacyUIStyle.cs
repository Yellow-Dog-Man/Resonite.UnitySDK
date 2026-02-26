
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyUIStyle
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyUIStyle")]
public partial class LegacyUIStyle : global::FrooxEngine.Component

{
    public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public UnityEngine.ColorX UserParentedColor { get => UserParentedColor_Element.Data; set => UserParentedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> UserParentedColor_Element = new();
public UnityEngine.ColorX PrivateColor { get => PrivateColor_Element.Data; set => PrivateColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PrivateColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("UserParentedColor", UserParentedColor_Element.ToLinkField(context));
members.Add("PrivateColor", PrivateColor_Element.ToLinkField(context));
}

}
}
