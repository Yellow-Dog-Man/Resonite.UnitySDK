
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoCaptureSettings
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoCaptureSettings")]
public partial class PhotoCaptureSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.PhotoCaptureSettings>

{
    public global::System.Boolean FingerGestureEnabled { get => FingerGestureEnabled_Element.Data; set => FingerGestureEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FingerGestureEnabled_Element = new();
public UnityEngine.Vector2Int NormalCaptureResolution { get => NormalCaptureResolution_Element.Data; set => NormalCaptureResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> NormalCaptureResolution_Element = new();
public UnityEngine.Vector2Int TimerCaptureResolution { get => TimerCaptureResolution_Element.Data; set => TimerCaptureResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> TimerCaptureResolution_Element = new();
public global::System.Single TimerSeconds { get => TimerSeconds_Element.Data; set => TimerSeconds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TimerSeconds_Element = new();
public global::System.Single HandsNearFOV { get => HandsNearFOV_Element.Data; set => HandsNearFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandsNearFOV_Element = new();
public global::System.Single HandsFarFOV { get => HandsFarFOV_Element.Data; set => HandsFarFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandsFarFOV_Element = new();
public global::System.Boolean CapturePrivateUI { get => CapturePrivateUI_Element.Data; set => CapturePrivateUI_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CapturePrivateUI_Element = new();
public global::System.Boolean CaptureStereo { get => CaptureStereo_Element.Data; set => CaptureStereo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CaptureStereo_Element = new();
public global::System.Single StereoSeparation { get => StereoSeparation_Element.Data; set => StereoSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StereoSeparation_Element = new();
public global::System.Boolean AlwaysHideNameplates { get => AlwaysHideNameplates_Element.Data; set => AlwaysHideNameplates_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlwaysHideNameplates_Element = new();
public global::FrooxEngine.PhotoEncodeFormat EncodeFormat { get => EncodeFormat_Element.Data; set => EncodeFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhotoEncodeFormat>, global::FrooxEngine.PhotoEncodeFormat> EncodeFormat_Element = new();
public global::System.String PhotoAutosavePath { get => PhotoAutosavePath_Element.Data; set => PhotoAutosavePath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PhotoAutosavePath_Element = new();
public global::System.Boolean AutosaveActive { get => AutosaveActive_Element.Data; set => AutosaveActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutosaveActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FingerGestureEnabled", FingerGestureEnabled_Element.Data.ToResoniteLinkField());
members.Add("NormalCaptureResolution", NormalCaptureResolution_Element.Data.ToResoniteLinkField());
members.Add("TimerCaptureResolution", TimerCaptureResolution_Element.Data.ToResoniteLinkField());
members.Add("TimerSeconds", TimerSeconds_Element.Data.ToResoniteLinkField());
members.Add("HandsNearFOV", HandsNearFOV_Element.Data.ToResoniteLinkField());
members.Add("HandsFarFOV", HandsFarFOV_Element.Data.ToResoniteLinkField());
members.Add("CapturePrivateUI", CapturePrivateUI_Element.Data.ToResoniteLinkField());
members.Add("CaptureStereo", CaptureStereo_Element.Data.ToResoniteLinkField());
members.Add("StereoSeparation", StereoSeparation_Element.Data.ToResoniteLinkField());
members.Add("AlwaysHideNameplates", AlwaysHideNameplates_Element.Data.ToResoniteLinkField());
members.Add("EncodeFormat", EncodeFormat_Element.Data.ToResoniteLinkField());
members.Add("PhotoAutosavePath", PhotoAutosavePath_Element.Data.ToResoniteLinkField());
members.Add("AutosaveActive", AutosaveActive_Element.Data.ToResoniteLinkField());
}

}
}
