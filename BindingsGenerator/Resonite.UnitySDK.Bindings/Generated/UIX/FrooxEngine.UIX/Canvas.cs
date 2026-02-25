
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Canvas
// Generated on: středa 25. února 2026 16:14:10
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
    public UnityEngine.Vector2 Size;
public global::System.Boolean EditModeOnly;
public global::System.Boolean AcceptRemoteTouch;
public global::System.Boolean AcceptPhysicalTouch;
public global::System.Boolean AcceptExistingTouch;
public global::System.Boolean HighPriorityIntegration;
public global::System.Boolean IgnoreTouchesFromBehind;
public global::System.Boolean BlockAllInteractions;
public global::System.Boolean LaserPassThrough;
public global::System.Single PixelScale;
public global::System.Single UnitScale;
public global::FrooxEngine.UIX.RectTransform _rootRect;
public global::FrooxEngine.BoxCollider Collider;
public global::FrooxEngine.Culling DefaultCulling;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset;
public global::System.Int32 StartingOffset;
public global::System.Int32 StartingMaskDepth;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch.ToResoniteLinkField());
members.Add("AcceptExistingTouch", AcceptExistingTouch.ToResoniteLinkField());
members.Add("HighPriorityIntegration", HighPriorityIntegration.ToResoniteLinkField());
members.Add("IgnoreTouchesFromBehind", IgnoreTouchesFromBehind.ToResoniteLinkField());
members.Add("BlockAllInteractions", BlockAllInteractions.ToResoniteLinkField());
members.Add("LaserPassThrough", LaserPassThrough.ToResoniteLinkField());
members.Add("PixelScale", PixelScale.ToResoniteLinkField());
members.Add("UnitScale", UnitScale.ToResoniteLinkField());
members.Add("_rootRect", _rootRect.ToResoniteReference(context));
members.Add("Collider", Collider.ToResoniteReference(context));
members.Add("DefaultCulling", DefaultCulling.ToResoniteLinkField());
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_colliderOffset", _colliderOffset.ToResoniteReference(context));
members.Add("StartingOffset", StartingOffset.ToResoniteLinkField());
members.Add("StartingMaskDepth", StartingMaskDepth.ToResoniteLinkField());
}

}
}
