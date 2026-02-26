
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObject
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObject")]
public partial class ScaleObject : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleObjectManager Manager { get => Manager_Element.Data; set => Manager_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ScaleObjectManager>, global::FrooxEngine.ScaleObjectManager> Manager_Element = new();
public global::System.Single ScalePower { get => ScalePower_Element.Data; set => ScalePower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ScalePower_Element = new();
public UnityEngine.Vector3 ScalePosition { get => ScalePosition_Element.Data; set => ScalePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ScalePosition_Element = new();
public global::System.Nullable<UnityEngine.Vector3> OverrideFarTransitionOffset { get => OverrideFarTransitionOffset_Element.Data; set => OverrideFarTransitionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> OverrideFarTransitionOffset_Element = new();
public global::System.Boolean CustomTransition { get => CustomTransition_Element.Data; set => CustomTransition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CustomTransition_Element = new();
public global::System.Single TransitionLerp { get => TransitionLerp_Element.Data; set => TransitionLerp_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> TransitionLerp_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _active { get => _active_Element.Data; set => _active_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _active_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Manager", Manager_Element.Data.ToResoniteReference(context));
members.Add("ScalePower", ScalePower_Element.Data.ToResoniteLinkField());
members.Add("ScalePosition", ScalePosition_Element.Data.ToResoniteLinkField());
members.Add("OverrideFarTransitionOffset", OverrideFarTransitionOffset_Element.Data.ToResoniteLinkField());
members.Add("CustomTransition", CustomTransition_Element.Data.ToResoniteLinkField());
members.Add("TransitionLerp", TransitionLerp_Element.Data.ToResoniteLinkField());
members.Add("_active", _active_Element.Data.ToResoniteReference(context));
members.Add("_position", _position_Element.Data.ToResoniteReference(context));
members.Add("_scale", _scale_Element.Data.ToResoniteReference(context));
}

}
}
