
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackPositionDriver
// Generated on: pátek 13. února 2026 23:21:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackPositionDriver")]
public partial class PlaybackPositionDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public global::FrooxEngine.IPlayable Source;
public global::System.Boolean UseNormalizedPosition;
public global::System.Boolean WriteBack;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("UseNormalizedPosition", UseNormalizedPosition.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}
