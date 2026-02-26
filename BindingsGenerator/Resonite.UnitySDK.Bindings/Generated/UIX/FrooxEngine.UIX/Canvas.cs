
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Canvas
// Generated on: čtvrtek 26. února 2026 10:04:32
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Canvas")]
public partial class Canvas : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.ITouchGrabbable, global::FrooxEngine.IBounded, global::FrooxEngine.ILaserInteractionModifier, global::FrooxEngine.IInteractionTarget, global::FrooxEngine.IContextMenuActionReceiver, global::FrooxEngine.ISecondaryActionReceiver, global::FrooxEngine.IAxisActionReceiver, global::FrooxEngine.IUIInterface, global::FrooxEngine.IRenderable

{
    public UnityEngine.Vector2 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Size_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptExistingTouch { get => AcceptExistingTouch_Element.Data; set => AcceptExistingTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptExistingTouch_Element = new();
public global::System.Boolean HighPriorityIntegration { get => HighPriorityIntegration_Element.Data; set => HighPriorityIntegration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HighPriorityIntegration_Element = new();
public global::System.Boolean IgnoreTouchesFromBehind { get => IgnoreTouchesFromBehind_Element.Data; set => IgnoreTouchesFromBehind_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreTouchesFromBehind_Element = new();
public global::System.Boolean BlockAllInteractions { get => BlockAllInteractions_Element.Data; set => BlockAllInteractions_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockAllInteractions_Element = new();
public global::System.Boolean LaserPassThrough { get => LaserPassThrough_Element.Data; set => LaserPassThrough_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LaserPassThrough_Element = new();
public global::System.Single PixelScale { get => PixelScale_Element.Data; set => PixelScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PixelScale_Element = new();
public global::System.Single UnitScale { get => UnitScale_Element.Data; set => UnitScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UnitScale_Element = new();
public global::FrooxEngine.UIX.RectTransform _rootRect { get => _rootRect_Element.Data; set => _rootRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _rootRect_Element = new();
public global::FrooxEngine.BoxCollider Collider { get => Collider_Element.Data; set => Collider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> Collider_Element = new();
public global::FrooxEngine.Culling DefaultCulling { get => DefaultCulling_Element.Data; set => DefaultCulling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Culling>, global::FrooxEngine.Culling> DefaultCulling_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset { get => _colliderOffset_Element.Data; set => _colliderOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderOffset_Element = new();
public global::System.Int32 StartingOffset { get => StartingOffset_Element.Data; set => StartingOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> StartingOffset_Element = new();
public global::System.Int32 StartingMaskDepth { get => StartingMaskDepth_Element.Data; set => StartingMaskDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> StartingMaskDepth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptExistingTouch", AcceptExistingTouch_Element.Data.ToResoniteLinkField());
members.Add("HighPriorityIntegration", HighPriorityIntegration_Element.Data.ToResoniteLinkField());
members.Add("IgnoreTouchesFromBehind", IgnoreTouchesFromBehind_Element.Data.ToResoniteLinkField());
members.Add("BlockAllInteractions", BlockAllInteractions_Element.Data.ToResoniteLinkField());
members.Add("LaserPassThrough", LaserPassThrough_Element.Data.ToResoniteLinkField());
members.Add("PixelScale", PixelScale_Element.Data.ToResoniteLinkField());
members.Add("UnitScale", UnitScale_Element.Data.ToResoniteLinkField());
members.Add("_rootRect", _rootRect_Element.Data.ToResoniteReference(context));
members.Add("Collider", Collider_Element.Data.ToResoniteReference(context));
members.Add("DefaultCulling", DefaultCulling_Element.Data.ToResoniteLinkField());
members.Add("_colliderSize", _colliderSize_Element.Data.ToResoniteReference(context));
members.Add("_colliderOffset", _colliderOffset_Element.Data.ToResoniteReference(context));
members.Add("StartingOffset", StartingOffset_Element.Data.ToResoniteLinkField());
members.Add("StartingMaskDepth", StartingMaskDepth_Element.Data.ToResoniteLinkField());
}

}
}
