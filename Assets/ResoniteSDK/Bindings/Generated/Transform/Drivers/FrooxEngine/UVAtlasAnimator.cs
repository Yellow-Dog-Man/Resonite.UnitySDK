
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVAtlasAnimator
// Generated on: sobota 14. února 2026 8:58:39
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleField", ScaleField.ToResoniteReference(context));
members.Add("OffsetField", OffsetField.ToResoniteReference(context));
members.Add("AtlasInfo", AtlasInfo.ToResoniteReference(context));
members.Add("Frame", Frame.ToResoniteLinkField());
}

}
}
