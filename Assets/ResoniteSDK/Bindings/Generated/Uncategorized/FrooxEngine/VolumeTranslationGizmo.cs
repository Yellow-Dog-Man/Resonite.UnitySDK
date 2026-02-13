
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeTranslationGizmo
// Generated on: pátek 13. února 2026 23:23:18
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PointSpace", new ResoniteLink.SyncObject() { Members = PointSpace.CollectMembers() });
members.Add("TargetPoint", new ResoniteLink.Reference() { });
members.Add("UseCustomVisual", UseCustomVisual.ToResoniteLinkField());
members.Add("_customVisualRoot", new ResoniteLink.Reference() { });
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("CubeSize", CubeSize.ToResoniteLinkField());
members.Add("CreateUndoSteps", CreateUndoSteps.ToResoniteLinkField());
members.Add("_cubeSize", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
}

}
}
