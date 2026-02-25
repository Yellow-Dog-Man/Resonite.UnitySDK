
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.UV_Vertical_Adapter
// Generated on: středa 25. února 2026 16:14:44
// Resonite version: 2026.2.25.455
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
    public UnityEngine.Vector2 OriginalUVOffset;
public UnityEngine.Vector2 OriginalUVScale;
public global::FrooxEngine.IField<UnityEngine.Vector2> UVOffset;
public global::FrooxEngine.IField<UnityEngine.Vector2> UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OriginalUVOffset", OriginalUVOffset.ToResoniteLinkField());
members.Add("OriginalUVScale", OriginalUVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteReference(context));
members.Add("UVScale", UVScale.ToResoniteReference(context));
}

}
}
