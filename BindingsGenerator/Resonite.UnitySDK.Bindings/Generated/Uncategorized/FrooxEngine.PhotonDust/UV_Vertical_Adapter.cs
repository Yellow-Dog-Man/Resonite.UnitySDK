
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.UV_Vertical_Adapter
// Generated on: čtvrtek 26. února 2026 12:28:14
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.UV_Vertical_Adapter")]
public partial class UV_Vertical_Adapter : global::FrooxEngine.Component

{
    public UnityEngine.Vector2 OriginalUVOffset { get => OriginalUVOffset_Element.Data; set => OriginalUVOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OriginalUVOffset_Element = new();
public UnityEngine.Vector2 OriginalUVScale { get => OriginalUVScale_Element.Data; set => OriginalUVScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> OriginalUVScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> UVOffset { get => UVOffset_Element.Data; set => UVOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> UVOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> UVScale { get => UVScale_Element.Data; set => UVScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> UVScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OriginalUVOffset", OriginalUVOffset_Element.ToLinkField(context));
members.Add("OriginalUVScale", OriginalUVScale_Element.ToLinkField(context));
members.Add("UVOffset", UVOffset_Element.ToLinkReference(context));
members.Add("UVScale", UVScale_Element.ToLinkReference(context));
}

}
}
