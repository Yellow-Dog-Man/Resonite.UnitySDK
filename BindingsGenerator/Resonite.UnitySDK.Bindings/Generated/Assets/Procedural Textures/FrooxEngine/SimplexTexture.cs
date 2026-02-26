
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexTexture
// Generated on: čtvrtek 26. února 2026 10:03:36
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexTexture")]
public partial class SimplexTexture : global::FrooxEngine.ProceduralTexture

{
    public UnityEngine.Vector2 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Offset_Element = new();
public UnityEngine.Vector2 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Scale_Element = new();
public UnityEngine.ColorX Background { get => Background_Element.Data; set => Background_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Background_Element = new();
public UnityEngine.ColorX Foreground { get => Foreground_Element.Data; set => Foreground_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Foreground_Element = new();
public global::System.Boolean Use3D { get => Use3D_Element.Data; set => Use3D_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Use3D_Element = new();
public global::System.Single ZOffset { get => ZOffset_Element.Data; set => ZOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ZOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset_Element.Data.ToResoniteLinkField());
members.Add("Scale", Scale_Element.Data.ToResoniteLinkField());
members.Add("Background", Background_Element.Data.ToResoniteLinkField());
members.Add("Foreground", Foreground_Element.Data.ToResoniteLinkField());
members.Add("Use3D", Use3D_Element.Data.ToResoniteLinkField());
members.Add("ZOffset", ZOffset_Element.Data.ToResoniteLinkField());
}

}
}
