
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.UV_Vertical_Adapter
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OriginalUVOffset", OriginalUVOffset.ToResoniteLinkField());
members.Add("OriginalUVScale", OriginalUVScale.ToResoniteLinkField());
members.Add("UVOffset", new ResoniteLink.Reference() { });
members.Add("UVScale", new ResoniteLink.Reference() { });
}

}
}
