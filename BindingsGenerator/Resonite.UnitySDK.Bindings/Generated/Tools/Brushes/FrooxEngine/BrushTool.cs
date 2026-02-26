
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrushTool
// Generated on: čtvrtek 26. února 2026 12:28:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrushTool")]
public abstract partial class BrushTool : global::FrooxEngine.Tool

{
    public global::System.Single FixedMinimumPointDistance { get => FixedMinimumPointDistance_Element.Data; set => FixedMinimumPointDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FixedMinimumPointDistance_Element = new();
public global::System.Single PositionSmoothing { get => PositionSmoothing_Element.Data; set => PositionSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PositionSmoothing_Element = new();
public global::System.Single RotationSmoothing { get => RotationSmoothing_Element.Data; set => RotationSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RotationSmoothing_Element = new();
public global::System.Single PressureSmoothing { get => PressureSmoothing_Element.Data; set => PressureSmoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PressureSmoothing_Element = new();
public global::System.Single MaxStrokeLength { get => MaxStrokeLength_Element.Data; set => MaxStrokeLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxStrokeLength_Element = new();
public global::System.Single StrokeFadeInLength { get => StrokeFadeInLength_Element.Data; set => StrokeFadeInLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrokeFadeInLength_Element = new();
public global::System.Single StrokeFadeOutLength { get => StrokeFadeOutLength_Element.Data; set => StrokeFadeOutLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrokeFadeOutLength_Element = new();
public global::System.Single StrokeGroupFinishWaitTime { get => StrokeGroupFinishWaitTime_Element.Data; set => StrokeGroupFinishWaitTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StrokeGroupFinishWaitTime_Element = new();
public global::System.Single ActivationThreshold { get => ActivationThreshold_Element.Data; set => ActivationThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ActivationThreshold_Element = new();
public global::System.Single DeactivationThresholdRatio { get => DeactivationThresholdRatio_Element.Data; set => DeactivationThresholdRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DeactivationThresholdRatio_Element = new();
public global::System.Single MenuSizeChange { get => MenuSizeChange_Element.Data; set => MenuSizeChange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MenuSizeChange_Element = new();
public global::System.Boolean SnapTip { get => SnapTip_Element.Data; set => SnapTip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SnapTip_Element = new();
public global::System.Boolean SnapLine { get => SnapLine_Element.Data; set => SnapLine_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SnapLine_Element = new();
public global::FrooxEngine.RootSpace StrokesSpace = new();
public global::System.Boolean MakeStrokesGrabbable { get => MakeStrokesGrabbable_Element.Data; set => MakeStrokesGrabbable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MakeStrokesGrabbable_Element = new();
public global::System.Boolean PositionStrokesToTip { get => PositionStrokesToTip_Element.Data; set => PositionStrokesToTip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PositionStrokesToTip_Element = new();
public global::System.Boolean OrientStrokesToTip { get => OrientStrokesToTip_Element.Data; set => OrientStrokesToTip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OrientStrokesToTip_Element = new();
public global::System.Boolean ScaleStrokesToUser { get => ScaleStrokesToUser_Element.Data; set => ScaleStrokesToUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleStrokesToUser_Element = new();
public global::System.Boolean PickMaterials { get => PickMaterials_Element.Data; set => PickMaterials_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PickMaterials_Element = new();
public global::System.Boolean PickColors { get => PickColors_Element.Data; set => PickColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PickColors_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> CurrentMaterial { get => CurrentMaterial_Element.Data; set => CurrentMaterial_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> CurrentMaterial_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.BrushTool.ColorMapping>, global::FrooxEngine.BrushTool.ColorMapping> ColorMappings = new();
public global::FrooxEngine.PhotonDust.ParticleSystem ParticleSystem { get => ParticleSystem_Element.Data; set => ParticleSystem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleSystem>, global::FrooxEngine.PhotonDust.ParticleSystem> ParticleSystem_Element = new();
public global::FrooxEngine.PhotonDust.MeshEmitter MeshEmitterTemplate { get => MeshEmitterTemplate_Element.Data; set => MeshEmitterTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.MeshEmitter>, global::FrooxEngine.PhotonDust.MeshEmitter> MeshEmitterTemplate_Element = new();
public global::FrooxEngine.BrushTool.TemplateHandling ParticleTemplateHandling { get => ParticleTemplateHandling_Element.Data; set => ParticleTemplateHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BrushTool.TemplateHandling>, global::FrooxEngine.BrushTool.TemplateHandling> ParticleTemplateHandling_Element = new();
public global::System.Nullable<global::System.Single> EmissionRatePerUnitLength { get => EmissionRatePerUnitLength_Element.Data; set => EmissionRatePerUnitLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> EmissionRatePerUnitLength_Element = new();
public global::FrooxEngine.ColorDialogInterface _colorPicker { get => _colorPicker_Element.Data; set => _colorPicker_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorPicker_Element = new();
public UnityEngine.ColorX _pickedColor { get => _pickedColor_Element.Data; set => _pickedColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> _pickedColor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> _hideOnStroke = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> _lastUsedMaterial { get => _lastUsedMaterial_Element.Data; set => _lastUsedMaterial_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> _lastUsedMaterial_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> _lastCreatedMaterial { get => _lastCreatedMaterial_Element.Data; set => _lastCreatedMaterial_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> _lastCreatedMaterial_Element = new();
public global::System.Single Pressure { get => Pressure_Element.Data; set => Pressure_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> Pressure_Element = new();
public UnityEngine.Vector3 Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> Position_Element = new();
public UnityEngine.Quaternion Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotation_Element = new();
public UnityEngine.Vector3 LastPointDelta { get => LastPointDelta_Element.Data; set => LastPointDelta_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> LastPointDelta_Element = new();
public UnityEngine.Vector3 Velocity { get => Velocity_Element.Data; set => Velocity_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> Velocity_Element = new();
public UnityEngine.Vector3 RawDelta { get => RawDelta_Element.Data; set => RawDelta_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> RawDelta_Element = new();
public UnityEngine.Vector3 RawVelocity { get => RawVelocity_Element.Data; set => RawVelocity_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector3>, UnityEngine.Vector3> RawVelocity_Element = new();
public global::System.Single RawStrokeLength { get => RawStrokeLength_Element.Data; set => RawStrokeLength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> RawStrokeLength_Element = new();
public global::System.Single StrokeLength { get => StrokeLength_Element.Data; set => StrokeLength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> StrokeLength_Element = new();
public global::System.Single NormalizedStrokeLength { get => NormalizedStrokeLength_Element.Data; set => NormalizedStrokeLength_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> NormalizedStrokeLength_Element = new();
public global::System.Single StrokeFadeMultiplier { get => StrokeFadeMultiplier_Element.Data; set => StrokeFadeMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> StrokeFadeMultiplier_Element = new();
public global::System.Int32 StrokeGroupIndex { get => StrokeGroupIndex_Element.Data; set => StrokeGroupIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> StrokeGroupIndex_Element = new();
public global::System.Boolean StrokeGroupActive { get => StrokeGroupActive_Element.Data; set => StrokeGroupActive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StrokeGroupActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FixedMinimumPointDistance", FixedMinimumPointDistance_Element.ToLinkField(context));
members.Add("PositionSmoothing", PositionSmoothing_Element.ToLinkField(context));
members.Add("RotationSmoothing", RotationSmoothing_Element.ToLinkField(context));
members.Add("PressureSmoothing", PressureSmoothing_Element.ToLinkField(context));
members.Add("MaxStrokeLength", MaxStrokeLength_Element.ToLinkField(context));
members.Add("StrokeFadeInLength", StrokeFadeInLength_Element.ToLinkField(context));
members.Add("StrokeFadeOutLength", StrokeFadeOutLength_Element.ToLinkField(context));
members.Add("StrokeGroupFinishWaitTime", StrokeGroupFinishWaitTime_Element.ToLinkField(context));
members.Add("ActivationThreshold", ActivationThreshold_Element.ToLinkField(context));
members.Add("DeactivationThresholdRatio", DeactivationThresholdRatio_Element.ToLinkField(context));
members.Add("MenuSizeChange", MenuSizeChange_Element.ToLinkField(context));
members.Add("SnapTip", SnapTip_Element.ToLinkField(context));
members.Add("SnapLine", SnapLine_Element.ToLinkField(context));
members.Add("StrokesSpace", StrokesSpace.ToLinkSyncObject(context));
members.Add("MakeStrokesGrabbable", MakeStrokesGrabbable_Element.ToLinkField(context));
members.Add("PositionStrokesToTip", PositionStrokesToTip_Element.ToLinkField(context));
members.Add("OrientStrokesToTip", OrientStrokesToTip_Element.ToLinkField(context));
members.Add("ScaleStrokesToUser", ScaleStrokesToUser_Element.ToLinkField(context));
members.Add("PickMaterials", PickMaterials_Element.ToLinkField(context));
members.Add("PickColors", PickColors_Element.ToLinkField(context));
members.Add("CurrentMaterial", CurrentMaterial_Element.ToLinkReference(context));
members.Add("ColorMappings", ColorMappings.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ParticleSystem", ParticleSystem_Element.ToLinkReference(context));
members.Add("MeshEmitterTemplate", MeshEmitterTemplate_Element.ToLinkReference(context));
members.Add("ParticleTemplateHandling", ParticleTemplateHandling_Element.ToLinkField(context));
members.Add("EmissionRatePerUnitLength", EmissionRatePerUnitLength_Element.ToLinkField(context));
members.Add("_colorPicker", _colorPicker_Element.ToLinkReference(context));
members.Add("_pickedColor", _pickedColor_Element.ToLinkField(context));
members.Add("_hideOnStroke", _hideOnStroke.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_lastUsedMaterial", _lastUsedMaterial_Element.ToLinkReference(context));
members.Add("_lastCreatedMaterial", _lastCreatedMaterial_Element.ToLinkReference(context));
members.Add("Pressure", Pressure_Element.ToLinkField(context));
members.Add("Position", Position_Element.ToLinkField(context));
members.Add("Rotation", Rotation_Element.ToLinkField(context));
members.Add("LastPointDelta", LastPointDelta_Element.ToLinkField(context));
members.Add("Velocity", Velocity_Element.ToLinkField(context));
members.Add("RawDelta", RawDelta_Element.ToLinkField(context));
members.Add("RawVelocity", RawVelocity_Element.ToLinkField(context));
members.Add("RawStrokeLength", RawStrokeLength_Element.ToLinkField(context));
members.Add("StrokeLength", StrokeLength_Element.ToLinkField(context));
members.Add("NormalizedStrokeLength", NormalizedStrokeLength_Element.ToLinkField(context));
members.Add("StrokeFadeMultiplier", StrokeFadeMultiplier_Element.ToLinkField(context));
members.Add("StrokeGroupIndex", StrokeGroupIndex_Element.ToLinkField(context));
members.Add("StrokeGroupActive", StrokeGroupActive_Element.ToLinkField(context));
}

}
}
