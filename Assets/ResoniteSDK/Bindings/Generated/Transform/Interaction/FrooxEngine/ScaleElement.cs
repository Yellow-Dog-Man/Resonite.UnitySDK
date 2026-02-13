
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleElement
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleElement")]
public partial class ScaleElement : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.ScaleGroup Group;
public global::System.Boolean RespondToPhysicalTouch;
public global::System.Boolean RespondToRemoteTouch;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Group", new ResoniteLink.Reference() { });
members.Add("RespondToPhysicalTouch", RespondToPhysicalTouch.ToResoniteLinkField());
members.Add("RespondToRemoteTouch", RespondToRemoteTouch.ToResoniteLinkField());
members.Add("_scaleTarget", new ResoniteLink.Reference() { });
}

}
}
