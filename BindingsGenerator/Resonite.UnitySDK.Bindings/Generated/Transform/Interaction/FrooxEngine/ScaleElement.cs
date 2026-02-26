
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleElement
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleElement")]
public partial class ScaleElement : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.ScaleGroup Group { get => Group_Element.Data; set => Group_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ScaleGroup>, global::FrooxEngine.ScaleGroup> Group_Element = new();
public global::System.Boolean RespondToPhysicalTouch { get => RespondToPhysicalTouch_Element.Data; set => RespondToPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RespondToPhysicalTouch_Element = new();
public global::System.Boolean RespondToRemoteTouch { get => RespondToRemoteTouch_Element.Data; set => RespondToRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RespondToRemoteTouch_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scaleTarget { get => _scaleTarget_Element.Data; set => _scaleTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scaleTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Group", Group_Element.Data.ToResoniteReference(context));
members.Add("RespondToPhysicalTouch", RespondToPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("RespondToRemoteTouch", RespondToRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("_scaleTarget", _scaleTarget_Element.Data.ToResoniteReference(context));
}

}
}
