
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+Tracker
// Generated on: čtvrtek 19. února 2026 8:00:27
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
    public partial class FullBodyCalibrator
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyCalibrator+Tracker")]
public partial class Tracker : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot VisualRoot;
public global::FrooxEngine.Slot TrackingReference;
public global::FrooxEngine.TrackedDevicePositioner TrackedDevice;
public global::FrooxEngine.OverlayFresnelMaterial Material;
public global::FrooxEngine.TextRenderer Label;
public global::FrooxEngine.Slot CalibrationReference;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _labelPosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _labelRotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VisualRoot", VisualRoot.ToResoniteReference(context));
members.Add("TrackingReference", TrackingReference.ToResoniteReference(context));
members.Add("TrackedDevice", TrackedDevice.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Label", Label.ToResoniteReference(context));
members.Add("CalibrationReference", CalibrationReference.ToResoniteReference(context));
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
members.Add("_labelPosition", _labelPosition.ToResoniteReference(context));
members.Add("_labelRotation", _labelRotation.ToResoniteReference(context));
}

}
            }
}
