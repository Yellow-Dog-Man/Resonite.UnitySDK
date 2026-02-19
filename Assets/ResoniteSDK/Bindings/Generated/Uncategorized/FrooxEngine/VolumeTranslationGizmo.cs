
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeTranslationGizmo
// Generated on: čtvrtek 19. února 2026 8:00:30
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeTranslationGizmo")]
public partial class VolumeTranslationGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.RootSpace PointSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetPoint;
public global::System.Boolean UseCustomVisual;
public global::FrooxEngine.Slot _customVisualRoot;
public global::FrooxEngine.Slot _visualRoot;
public global::System.Single CubeSize;
public global::System.Boolean CreateUndoSteps;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cubeSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers(context) });
members.Add("TargetPoint", TargetPoint.ToResoniteReference(context));
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", _customVisualRoot.ToResoniteReference(context));
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("CubeSize", CubeSize.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_cubeSize", _cubeSize.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
}

}
}
