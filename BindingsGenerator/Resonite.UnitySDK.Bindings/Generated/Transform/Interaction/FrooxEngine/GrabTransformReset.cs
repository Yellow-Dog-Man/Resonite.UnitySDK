
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabTransformReset
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabTransformReset")]
public partial class GrabTransformReset : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::System.Boolean ResetPositionOnGrab { get => ResetPositionOnGrab_Element.Data; set => ResetPositionOnGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetPositionOnGrab_Element = new();
public global::System.Boolean ResetRotationOnGrab { get => ResetRotationOnGrab_Element.Data; set => ResetRotationOnGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetRotationOnGrab_Element = new();
public global::System.Boolean ResetScaleOnGrab { get => ResetScaleOnGrab_Element.Data; set => ResetScaleOnGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetScaleOnGrab_Element = new();
public global::System.Boolean ResetPositionOnRelease { get => ResetPositionOnRelease_Element.Data; set => ResetPositionOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetPositionOnRelease_Element = new();
public global::System.Boolean ResetRotationOnRelease { get => ResetRotationOnRelease_Element.Data; set => ResetRotationOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetRotationOnRelease_Element = new();
public global::System.Boolean ResetScaleOnRelease { get => ResetScaleOnRelease_Element.Data; set => ResetScaleOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetScaleOnRelease_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ResetPositionOnGrab", ResetPositionOnGrab_Element.Data.ToResoniteLinkField());
members.Add("ResetRotationOnGrab", ResetRotationOnGrab_Element.Data.ToResoniteLinkField());
members.Add("ResetScaleOnGrab", ResetScaleOnGrab_Element.Data.ToResoniteLinkField());
members.Add("ResetPositionOnRelease", ResetPositionOnRelease_Element.Data.ToResoniteLinkField());
members.Add("ResetRotationOnRelease", ResetRotationOnRelease_Element.Data.ToResoniteLinkField());
members.Add("ResetScaleOnRelease", ResetScaleOnRelease_Element.Data.ToResoniteLinkField());
}

}
}
