
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Slider
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Slider")]
public partial class Slider : global::FrooxEngine.Draggable

{
    public global::System.Boolean Rotatable { get => Rotatable_Element.Data; set => Rotatable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Rotatable_Element = new();
public global::System.Boolean Scalable { get => Scalable_Element.Data; set => Scalable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Scalable_Element = new();
public UnityEngine.Vector3 Range { get => Range_Element.Data; set => Range_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Range_Element = new();
public UnityEngine.Vector3 Origin { get => Origin_Element.Data; set => Origin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Origin_Element = new();
public UnityEngine.Vector3 MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MinScale_Element = new();
public UnityEngine.Vector3 MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MaxScale_Element = new();
public global::System.Single VibrationOffset { get => VibrationOffset_Element.Data; set => VibrationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VibrationOffset_Element = new();
public global::FrooxEngine.VibratePreset VibrationPreset { get => VibrationPreset_Element.Data; set => VibrationPreset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> VibrationPreset_Element = new();
public global::System.Single SnapIncrement { get => SnapIncrement_Element.Data; set => SnapIncrement_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapIncrement_Element = new();
public global::System.Single SnapTime { get => SnapTime_Element.Data; set => SnapTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapTime_Element = new();
public global::System.Boolean SnapOnRelease { get => SnapOnRelease_Element.Data; set => SnapOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SnapOnRelease_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.Slider.SnapPosition>, global::FrooxEngine.Slider.SnapPosition> SnapPositions = new();
public UnityEngine.Vector3 posOffset { get => posOffset_Element.Data; set => posOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> posOffset_Element = new();
public UnityEngine.Quaternion rotOffset { get => rotOffset_Element.Data; set => rotOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> rotOffset_Element = new();
public UnityEngine.Vector3 scaleReference { get => scaleReference_Element.Data; set => scaleReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> scaleReference_Element = new();
public global::FrooxEngine.Slot referenceParent { get => referenceParent_Element.Data; set => referenceParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> referenceParent_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotatable", Rotatable_Element.ToLinkField(context));
members.Add("Scalable", Scalable_Element.ToLinkField(context));
members.Add("Range", Range_Element.ToLinkField(context));
members.Add("Origin", Origin_Element.ToLinkField(context));
members.Add("MinScale", MinScale_Element.ToLinkField(context));
members.Add("MaxScale", MaxScale_Element.ToLinkField(context));
members.Add("VibrationOffset", VibrationOffset_Element.ToLinkField(context));
members.Add("VibrationPreset", VibrationPreset_Element.ToLinkField(context));
members.Add("SnapIncrement", SnapIncrement_Element.ToLinkField(context));
members.Add("SnapTime", SnapTime_Element.ToLinkField(context));
members.Add("SnapOnRelease", SnapOnRelease_Element.ToLinkField(context));
members.Add("SnapPositions", SnapPositions.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("posOffset", posOffset_Element.ToLinkField(context));
members.Add("rotOffset", rotOffset_Element.ToLinkField(context));
members.Add("scaleReference", scaleReference_Element.ToLinkField(context));
members.Add("referenceParent", referenceParent_Element.ToLinkReference(context));
}

}
}
