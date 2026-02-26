
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraFramingSettings
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraFramingSettings")]
public partial class InteractiveCameraFramingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraFramingSettings>

{
    public global::FrooxEngine.CameraPositioningMode PositioningMode { get => PositioningMode_Element.Data; set => PositioningMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraPositioningMode>, global::FrooxEngine.CameraPositioningMode> PositioningMode_Element = new();
public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::System.Single AnglePosition { get => AnglePosition_Element.Data; set => AnglePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnglePosition_Element = new();
public global::System.Single Distance { get => Distance_Element.Data; set => Distance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Distance_Element = new();
public global::System.Single HeightOffset { get => HeightOffset_Element.Data; set => HeightOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightOffset_Element = new();
public global::System.Single FirstPersonPitch { get => FirstPersonPitch_Element.Data; set => FirstPersonPitch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonPitch_Element = new();
public global::System.Single FirstPersonRoll { get => FirstPersonRoll_Element.Data; set => FirstPersonRoll_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonRoll_Element = new();
public global::System.Single FirstPersonOffset { get => FirstPersonOffset_Element.Data; set => FirstPersonOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FirstPersonOffset_Element = new();
public UnityEngine.Vector2 FramingViewportPosition { get => FramingViewportPosition_Element.Data; set => FramingViewportPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FramingViewportPosition_Element = new();
public global::System.Boolean AimInFrontOfHead { get => AimInFrontOfHead_Element.Data; set => AimInFrontOfHead_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AimInFrontOfHead_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositioningMode", PositioningMode_Element.ToLinkField(context));
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("AnglePosition", AnglePosition_Element.ToLinkField(context));
members.Add("Distance", Distance_Element.ToLinkField(context));
members.Add("HeightOffset", HeightOffset_Element.ToLinkField(context));
members.Add("FirstPersonPitch", FirstPersonPitch_Element.ToLinkField(context));
members.Add("FirstPersonRoll", FirstPersonRoll_Element.ToLinkField(context));
members.Add("FirstPersonOffset", FirstPersonOffset_Element.ToLinkField(context));
members.Add("FramingViewportPosition", FramingViewportPosition_Element.ToLinkField(context));
members.Add("AimInFrontOfHead", AimInFrontOfHead_Element.ToLinkField(context));
}

}
}
