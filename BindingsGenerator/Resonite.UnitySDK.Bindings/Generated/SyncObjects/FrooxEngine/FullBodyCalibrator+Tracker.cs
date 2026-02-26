
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+Tracker
// Generated on: čtvrtek 26. února 2026 12:28:11
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
    public partial class FullBodyCalibrator
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyCalibrator+Tracker")]
public partial class Tracker : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot VisualRoot { get => VisualRoot_Element.Data; set => VisualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> VisualRoot_Element = new();
public global::FrooxEngine.Slot TrackingReference { get => TrackingReference_Element.Data; set => TrackingReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TrackingReference_Element = new();
public global::FrooxEngine.TrackedDevicePositioner TrackedDevice { get => TrackedDevice_Element.Data; set => TrackedDevice_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TrackedDevicePositioner>, global::FrooxEngine.TrackedDevicePositioner> TrackedDevice_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> Material_Element = new();
public global::FrooxEngine.TextRenderer Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> Label_Element = new();
public global::FrooxEngine.Slot CalibrationReference { get => CalibrationReference_Element.Data; set => CalibrationReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CalibrationReference_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _labelPosition { get => _labelPosition_Element.Data; set => _labelPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _labelPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _labelRotation { get => _labelRotation_Element.Data; set => _labelRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _labelRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VisualRoot", VisualRoot_Element.ToLinkReference(context));
members.Add("TrackingReference", TrackingReference_Element.ToLinkReference(context));
members.Add("TrackedDevice", TrackedDevice_Element.ToLinkReference(context));
members.Add("Material", Material_Element.ToLinkReference(context));
members.Add("Label", Label_Element.ToLinkReference(context));
members.Add("CalibrationReference", CalibrationReference_Element.ToLinkReference(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
members.Add("_labelPosition", _labelPosition_Element.ToLinkReference(context));
members.Add("_labelRotation", _labelRotation_Element.ToLinkReference(context));
}

}
            }
}
