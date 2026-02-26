
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.KnobControl
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.KnobControl")]
public partial class KnobControl : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Single> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Target_Element = new();
public UnityEngine.Vector3 RotationAxis { get => RotationAxis_Element.Data; set => RotationAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> RotationAxis_Element = new();
public global::System.Single Rate { get => Rate_Element.Data; set => Rate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Rate_Element = new();
public global::System.Single Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Min_Element = new();
public global::System.Single Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Max_Element = new();
public global::System.Single _lastRotation { get => _lastRotation_Element.Data; set => _lastRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _lastRotation_Element = new();
public UnityEngine.Vector3 _lastAxis { get => _lastAxis_Element.Data; set => _lastAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _lastAxis_Element = new();
public global::FrooxEngine.User _lastUser { get => _lastUser_Element.Data; set => _lastUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _lastUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("RotationAxis", RotationAxis_Element.Data.ToResoniteLinkField());
members.Add("Rate", Rate_Element.Data.ToResoniteLinkField());
members.Add("Min", Min_Element.Data.ToResoniteLinkField());
members.Add("Max", Max_Element.Data.ToResoniteLinkField());
members.Add("_lastRotation", _lastRotation_Element.Data.ToResoniteLinkField());
members.Add("_lastAxis", _lastAxis_Element.Data.ToResoniteLinkField());
members.Add("_lastUser", _lastUser_Element.Data.ToResoniteReference(context));
}

}
}
