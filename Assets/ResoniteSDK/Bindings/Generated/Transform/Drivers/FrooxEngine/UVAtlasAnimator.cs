
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVAtlasAnimator
// Generated on: pátek 13. února 2026 23:23:10
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UVAtlasAnimator")]
public partial class UVAtlasAnimator : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> ScaleField;
public global::FrooxEngine.IField<UnityEngine.Vector2> OffsetField;
public global::FrooxEngine.AtlasInfo AtlasInfo;
public global::System.Int32 Frame;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ScaleField", new ResoniteLink.Reference() { });
members.Add("OffsetField", new ResoniteLink.Reference() { });
members.Add("AtlasInfo", new ResoniteLink.Reference() { });
members.Add("Frame", Frame.ToResoniteLinkField());
}

}
}
