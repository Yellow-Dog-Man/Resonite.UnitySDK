
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LinearAngleMapper
// Generated on: čtvrtek 26. února 2026 15:09:07
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LinearAngleMapper")]
public partial class LinearAngleMapper : global::FrooxEngine.Component

{
    public global::FrooxEngine.IValue<global::System.Single> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<global::System.Single>>, global::FrooxEngine.IValue<global::System.Single>> Source_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> Target_Element = new();
public global::System.Single SourceMin { get => SourceMin_Element.Data; set => SourceMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SourceMin_Element = new();
public global::System.Single SourceMax { get => SourceMax_Element.Data; set => SourceMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SourceMax_Element = new();
public UnityEngine.Vector3 TargetMin { get => TargetMin_Element.Data; set => TargetMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetMin_Element = new();
public UnityEngine.Vector3 TargetMax { get => TargetMax_Element.Data; set => TargetMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> TargetMax_Element = new();
public global::System.Boolean AllowReverseMapping { get => AllowReverseMapping_Element.Data; set => AllowReverseMapping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowReverseMapping_Element = new();
public global::System.Boolean Clamp { get => Clamp_Element.Data; set => Clamp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Clamp_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("SourceMin", SourceMin_Element.ToLinkField(context));
members.Add("SourceMax", SourceMax_Element.ToLinkField(context));
members.Add("TargetMin", TargetMin_Element.ToLinkField(context));
members.Add("TargetMax", TargetMax_Element.ToLinkField(context));
members.Add("AllowReverseMapping", AllowReverseMapping_Element.ToLinkField(context));
members.Add("Clamp", Clamp_Element.ToLinkField(context));
}

}
}
