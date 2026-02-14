
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabTransformReset
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabTransformReset")]
public partial class GrabTransformReset : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::System.Boolean ResetPositionOnGrab;
public global::System.Boolean ResetRotationOnGrab;
public global::System.Boolean ResetScaleOnGrab;
public global::System.Boolean ResetPositionOnRelease;
public global::System.Boolean ResetRotationOnRelease;
public global::System.Boolean ResetScaleOnRelease;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetPositionOnGrab", ResetPositionOnGrab.ToResoniteLinkField());
members.Add("ResetRotationOnGrab", ResetRotationOnGrab.ToResoniteLinkField());
members.Add("ResetScaleOnGrab", ResetScaleOnGrab.ToResoniteLinkField());
members.Add("ResetPositionOnRelease", ResetPositionOnRelease.ToResoniteLinkField());
members.Add("ResetRotationOnRelease", ResetRotationOnRelease.ToResoniteLinkField());
members.Add("ResetScaleOnRelease", ResetScaleOnRelease.ToResoniteLinkField());
}

}
}
