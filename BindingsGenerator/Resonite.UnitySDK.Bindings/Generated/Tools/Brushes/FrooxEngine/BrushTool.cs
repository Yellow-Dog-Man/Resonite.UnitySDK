
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrushTool
// Generated on: středa 25. února 2026 16:14:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrushTool")]
public abstract partial class BrushTool : global::FrooxEngine.Tool

{
    public global::System.Single FixedMinimumPointDistance;
public global::System.Single PositionSmoothing;
public global::System.Single RotationSmoothing;
public global::System.Single PressureSmoothing;
public global::System.Single MaxStrokeLength;
public global::System.Single StrokeFadeInLength;
public global::System.Single StrokeFadeOutLength;
public global::System.Single StrokeGroupFinishWaitTime;
public global::System.Single ActivationThreshold;
public global::System.Single DeactivationThresholdRatio;
public global::System.Single MenuSizeChange;
public global::System.Boolean SnapTip;
public global::System.Boolean SnapLine;
public global::FrooxEngine.RootSpace StrokesSpace;
public global::System.Boolean MakeStrokesGrabbable;
public global::System.Boolean PositionStrokesToTip;
public global::System.Boolean OrientStrokesToTip;
public global::System.Boolean ScaleStrokesToUser;
public global::System.Boolean PickMaterials;
public global::System.Boolean PickColors;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> CurrentMaterial;
public System.Collections.Generic.List<global::FrooxEngine.BrushTool.ColorMapping> ColorMappings;
public global::FrooxEngine.PhotonDust.ParticleSystem ParticleSystem;
public global::FrooxEngine.PhotonDust.MeshEmitter MeshEmitterTemplate;
public global::FrooxEngine.BrushTool.TemplateHandling ParticleTemplateHandling;
public global::System.Nullable<global::System.Single> EmissionRatePerUnitLength;
public global::FrooxEngine.ColorDialogInterface _colorPicker;
public UnityEngine.ColorX _pickedColor;
public System.Collections.Generic.List<global::FrooxEngine.Slot> _hideOnStroke;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> _lastUsedMaterial;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> _lastCreatedMaterial;
public global::System.Single Pressure;
public UnityEngine.Vector3 Position;
public UnityEngine.Quaternion Rotation;
public UnityEngine.Vector3 LastPointDelta;
public UnityEngine.Vector3 Velocity;
public UnityEngine.Vector3 RawDelta;
public UnityEngine.Vector3 RawVelocity;
public global::System.Single RawStrokeLength;
public global::System.Single StrokeLength;
public global::System.Single NormalizedStrokeLength;
public global::System.Single StrokeFadeMultiplier;
public global::System.Int32 StrokeGroupIndex;
public global::System.Boolean StrokeGroupActive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FixedMinimumPointDistance", FixedMinimumPointDistance.ToResoniteLinkField());
members.Add("PositionSmoothing", PositionSmoothing.ToResoniteLinkField());
members.Add("RotationSmoothing", RotationSmoothing.ToResoniteLinkField());
members.Add("PressureSmoothing", PressureSmoothing.ToResoniteLinkField());
members.Add("MaxStrokeLength", MaxStrokeLength.ToResoniteLinkField());
members.Add("StrokeFadeInLength", StrokeFadeInLength.ToResoniteLinkField());
members.Add("StrokeFadeOutLength", StrokeFadeOutLength.ToResoniteLinkField());
members.Add("StrokeGroupFinishWaitTime", StrokeGroupFinishWaitTime.ToResoniteLinkField());
members.Add("ActivationThreshold", ActivationThreshold.ToResoniteLinkField());
members.Add("DeactivationThresholdRatio", DeactivationThresholdRatio.ToResoniteLinkField());
members.Add("MenuSizeChange", MenuSizeChange.ToResoniteLinkField());
members.Add("SnapTip", SnapTip.ToResoniteLinkField());
members.Add("SnapLine", SnapLine.ToResoniteLinkField());
members.Add("StrokesSpace", new ResoniteLink.SyncObject() { Members = StrokesSpace.CollectMembers(context) });
members.Add("MakeStrokesGrabbable", MakeStrokesGrabbable.ToResoniteLinkField());
members.Add("PositionStrokesToTip", PositionStrokesToTip.ToResoniteLinkField());
members.Add("OrientStrokesToTip", OrientStrokesToTip.ToResoniteLinkField());
members.Add("ScaleStrokesToUser", ScaleStrokesToUser.ToResoniteLinkField());
members.Add("PickMaterials", PickMaterials.ToResoniteLinkField());
members.Add("PickColors", PickColors.ToResoniteLinkField());
members.Add("CurrentMaterial", CurrentMaterial.ToResoniteReference(context));
members.Add("ColorMappings", new ResoniteLink.SyncList()
{
    Elements = ColorMappings.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("ParticleSystem", ParticleSystem.ToResoniteReference(context));
members.Add("MeshEmitterTemplate", MeshEmitterTemplate.ToResoniteReference(context));
members.Add("ParticleTemplateHandling", ParticleTemplateHandling.ToResoniteLinkField());
members.Add("EmissionRatePerUnitLength", EmissionRatePerUnitLength.ToResoniteLinkField());
members.Add("_colorPicker", _colorPicker.ToResoniteReference(context));
members.Add("_pickedColor", _pickedColor.ToResoniteLinkField());
members.Add("_hideOnStroke", new ResoniteLink.SyncList()
{
    Elements = _hideOnStroke.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_lastUsedMaterial", _lastUsedMaterial.ToResoniteReference(context));
members.Add("_lastCreatedMaterial", _lastCreatedMaterial.ToResoniteReference(context));
members.Add("Pressure", Pressure.ToResoniteLinkField());
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("LastPointDelta", LastPointDelta.ToResoniteLinkField());
members.Add("Velocity", Velocity.ToResoniteLinkField());
members.Add("RawDelta", RawDelta.ToResoniteLinkField());
members.Add("RawVelocity", RawVelocity.ToResoniteLinkField());
members.Add("RawStrokeLength", RawStrokeLength.ToResoniteLinkField());
members.Add("StrokeLength", StrokeLength.ToResoniteLinkField());
members.Add("NormalizedStrokeLength", NormalizedStrokeLength.ToResoniteLinkField());
members.Add("StrokeFadeMultiplier", StrokeFadeMultiplier.ToResoniteLinkField());
members.Add("StrokeGroupIndex", StrokeGroupIndex.ToResoniteLinkField());
members.Add("StrokeGroupActive", StrokeGroupActive.ToResoniteLinkField());
}

}
}
