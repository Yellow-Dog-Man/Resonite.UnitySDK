
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleTransition
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleTransition")]
public partial class ScaleTransition : global::FrooxEngine.Component

{
    public global::System.Boolean ShowField { get => ShowField_Element.Data; set => ShowField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowField_Element = new();
public global::System.Single TransitionTimeField { get => TransitionTimeField_Element.Data; set => TransitionTimeField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TransitionTimeField_Element = new();
public UnityEngine.Vector3 ShowScaleField { get => ShowScaleField_Element.Data; set => ShowScaleField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ShowScaleField_Element = new();
public UnityEngine.Vector3 HiddenScaleField { get => HiddenScaleField_Element.Data; set => HiddenScaleField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HiddenScaleField_Element = new();
public global::FrooxEngine.CurvePreset CurveField { get => CurveField_Element.Data; set => CurveField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CurvePreset>, global::FrooxEngine.CurvePreset> CurveField_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleDrive { get => _scaleDrive_Element.Data; set => _scaleDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scaleDrive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _enabledDrive { get => _enabledDrive_Element.Data; set => _enabledDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _enabledDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowField", ShowField_Element.ToLinkField(context));
members.Add("TransitionTimeField", TransitionTimeField_Element.ToLinkField(context));
members.Add("ShowScaleField", ShowScaleField_Element.ToLinkField(context));
members.Add("HiddenScaleField", HiddenScaleField_Element.ToLinkField(context));
members.Add("CurveField", CurveField_Element.ToLinkField(context));
members.Add("_scaleDrive", _scaleDrive_Element.ToLinkReference(context));
members.Add("_enabledDrive", _enabledDrive_Element.ToLinkReference(context));
}

}
}
