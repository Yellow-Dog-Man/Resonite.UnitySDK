
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleTransition
// Generated on: pátek 13. února 2026 23:23:09
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ShowField", ShowField.ToResoniteLinkField());
members.Add("TransitionTimeField", TransitionTimeField.ToResoniteLinkField());
members.Add("ShowScaleField", ShowScaleField.ToResoniteLinkField());
members.Add("HiddenScaleField", HiddenScaleField.ToResoniteLinkField());
members.Add("CurveField", CurveField.ToResoniteLinkField());
members.Add("_scaleDrive", new ResoniteLink.Reference() { });
members.Add("_enabledDrive", new ResoniteLink.Reference() { });
}

}
}
