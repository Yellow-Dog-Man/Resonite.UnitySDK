
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackPositionDriver
// Generated on: středa 25. února 2026 16:13:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackPositionDriver")]
public partial class PlaybackPositionDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public global::FrooxEngine.IPlayable Source;
public global::System.Boolean UseNormalizedPosition;
public global::System.Boolean WriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Source", Source.ToResoniteReference(context));
members.Add("UseNormalizedPosition", UseNormalizedPosition.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}
