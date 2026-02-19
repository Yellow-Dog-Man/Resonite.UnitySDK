
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleTransition
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleTransition")]
public partial class ScaleTransition : global::FrooxEngine.Component

{
    public global::System.Boolean ShowField;
public global::System.Single TransitionTimeField;
public UnityEngine.Vector3 ShowScaleField;
public UnityEngine.Vector3 HiddenScaleField;
public global::FrooxEngine.CurvePreset CurveField;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleDrive;
public global::FrooxEngine.IField<global::System.Boolean> _enabledDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowField", ShowField.ToResoniteLinkField());
members.Add("TransitionTimeField", TransitionTimeField.ToResoniteLinkField());
members.Add("ShowScaleField", ShowScaleField.ToResoniteLinkField());
members.Add("HiddenScaleField", HiddenScaleField.ToResoniteLinkField());
members.Add("CurveField", CurveField.ToResoniteLinkField());
members.Add("_scaleDrive", _scaleDrive.ToResoniteReference(context));
members.Add("_enabledDrive", _enabledDrive.ToResoniteReference(context));
}

}
}
