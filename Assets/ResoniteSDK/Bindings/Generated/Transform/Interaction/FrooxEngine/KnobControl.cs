
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.KnobControl
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.KnobControl")]
public partial class KnobControl : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public UnityEngine.Vector3 RotationAxis;
public global::System.Single Rate;
public global::System.Single Min;
public global::System.Single Max;
public global::System.Single _lastRotation;
public UnityEngine.Vector3 _lastAxis;
public global::FrooxEngine.User _lastUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("RotationAxis", RotationAxis.ToResoniteLinkField());
members.Add("Rate", Rate.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("_lastRotation", _lastRotation.ToResoniteLinkField());
members.Add("_lastAxis", _lastAxis.ToResoniteLinkField());
members.Add("_lastUser", _lastUser.ToResoniteReference(context));
}

}
}
