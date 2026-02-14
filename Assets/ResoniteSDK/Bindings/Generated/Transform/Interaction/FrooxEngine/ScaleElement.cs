
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleElement
// Generated on: sobota 14. února 2026 8:58:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleElement")]
public partial class ScaleElement : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.ScaleGroup Group;
public global::System.Boolean RespondToPhysicalTouch;
public global::System.Boolean RespondToRemoteTouch;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Group", Group.ToResoniteReference(context));
members.Add("RespondToPhysicalTouch", RespondToPhysicalTouch.ToResoniteLinkField());
members.Add("RespondToRemoteTouch", RespondToRemoteTouch.ToResoniteLinkField());
members.Add("_scaleTarget", _scaleTarget.ToResoniteReference(context));
}

}
}
