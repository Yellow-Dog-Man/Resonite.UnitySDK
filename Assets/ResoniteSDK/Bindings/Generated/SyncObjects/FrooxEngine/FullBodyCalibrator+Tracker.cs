
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibrator+Tracker
// Generated on: pátek 13. února 2026 23:23:14
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("VisualRoot", new ResoniteLink.Reference() { });
members.Add("TrackingReference", new ResoniteLink.Reference() { });
members.Add("TrackedDevice", new ResoniteLink.Reference() { });
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Label", new ResoniteLink.Reference() { });
members.Add("CalibrationReference", new ResoniteLink.Reference() { });
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_rotation", new ResoniteLink.Reference() { });
members.Add("_labelPosition", new ResoniteLink.Reference() { });
members.Add("_labelRotation", new ResoniteLink.Reference() { });
}

}
            }
}
