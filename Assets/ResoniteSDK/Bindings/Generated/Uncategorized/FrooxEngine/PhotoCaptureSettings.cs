
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoCaptureSettings
// Generated on: úterý 24. února 2026 18:20:26
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoCaptureSettings")]
public partial class PhotoCaptureSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.PhotoCaptureSettings>

{
    public global::System.Boolean FingerGestureEnabled;
public UnityEngine.Vector2Int NormalCaptureResolution;
public UnityEngine.Vector2Int TimerCaptureResolution;
public global::System.Single TimerSeconds;
public global::System.Single HandsNearFOV;
public global::System.Single HandsFarFOV;
public global::System.Boolean CapturePrivateUI;
public global::System.Boolean CaptureStereo;
public global::System.Single StereoSeparation;
public global::System.Boolean AlwaysHideNameplates;
public global::FrooxEngine.PhotoEncodeFormat EncodeFormat;
public global::System.String PhotoAutosavePath;
public global::System.Boolean AutosaveActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FingerGestureEnabled", FingerGestureEnabled.ToResoniteLinkField());
members.Add("NormalCaptureResolution", NormalCaptureResolution.ToResoniteLinkField());
members.Add("TimerCaptureResolution", TimerCaptureResolution.ToResoniteLinkField());
members.Add("TimerSeconds", TimerSeconds.ToResoniteLinkField());
members.Add("HandsNearFOV", HandsNearFOV.ToResoniteLinkField());
members.Add("HandsFarFOV", HandsFarFOV.ToResoniteLinkField());
members.Add("CapturePrivateUI", CapturePrivateUI.ToResoniteLinkField());
members.Add("CaptureStereo", CaptureStereo.ToResoniteLinkField());
members.Add("StereoSeparation", StereoSeparation.ToResoniteLinkField());
members.Add("AlwaysHideNameplates", AlwaysHideNameplates.ToResoniteLinkField());
members.Add("EncodeFormat", EncodeFormat.ToResoniteLinkField());
members.Add("PhotoAutosavePath", PhotoAutosavePath.ToResoniteLinkField());
members.Add("AutosaveActive", AutosaveActive.ToResoniteLinkField());
}

}
}
