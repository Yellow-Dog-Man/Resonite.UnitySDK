
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeTranslationGizmo
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeTranslationGizmo")]
public partial class VolumeTranslationGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.RootSpace PointSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint { get => TargetPoint_Element.Data; set => TargetPoint_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetPoint_Element = new();
public global::System.Boolean UseCustomVisual { get => UseCustomVisual_Element.Data; set => UseCustomVisual_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseCustomVisual_Element = new();
public global::FrooxEngine.Slot _customVisualRoot { get => _customVisualRoot_Element.Data; set => _customVisualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _customVisualRoot_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::System.Single CubeSize { get => CubeSize_Element.Data; set => CubeSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CubeSize_Element = new();
public global::System.Boolean CreateUndoSteps { get => CreateUndoSteps_Element.Data; set => CreateUndoSteps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateUndoSteps_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cubeSize { get => _cubeSize_Element.Data; set => _cubeSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cubeSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", PointSpace.ToLinkSyncObject(context));
members.Add("TargetPoint", TargetPoint_Element.ToLinkReference(context));
members.Add("UseCustomVisual", UseCustomVisual_Element.ToLinkField(context));
members.Add("_customVisualRoot", _customVisualRoot_Element.ToLinkReference(context));
members.Add("_visualRoot", _visualRoot_Element.ToLinkReference(context));
members.Add("CubeSize", CubeSize_Element.ToLinkField(context));
members.Add("CreateUndoSteps", CreateUndoSteps_Element.ToLinkField(context));
members.Add("_cubeSize", _cubeSize_Element.ToLinkReference(context));
members.Add("_colliderSize", _colliderSize_Element.ToLinkReference(context));
}

}
}
