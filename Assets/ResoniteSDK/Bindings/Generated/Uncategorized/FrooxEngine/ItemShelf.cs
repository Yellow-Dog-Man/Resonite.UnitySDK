
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ItemShelf
// Generated on: sobota 14. února 2026 8:58:27
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ItemShelf")]
public partial class ItemShelf : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock, global::FrooxEngine.IInteractionTarget

{
    public global::FrooxEngine.ItemShelf.Direction GrowDirection;
public global::FrooxEngine.Grabber IgnoreGrabber;
public global::System.Single MinLength;
public global::System.Single Width;
public global::System.Single Thickness;
public global::System.Single MaxItemSize;
public global::System.Single MaxPlaneDistance;
public global::System.Single MaxHeightDistance;
public global::System.Single _targetLength;
public global::FrooxEngine.Slot _visual;
public global::FrooxEngine.Slot _content;
public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualOffset;
public global::FrooxEngine.BevelStripeMesh _shelfMesh;
public global::FrooxEngine.BoxCollider _collider;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GrowDirection", GrowDirection.ToResoniteLinkField());
members.Add("IgnoreGrabber", IgnoreGrabber.ToResoniteReference(context));
members.Add("MinLength", MinLength.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("MaxItemSize", MaxItemSize.ToResoniteLinkField());
members.Add("MaxPlaneDistance", MaxPlaneDistance.ToResoniteLinkField());
members.Add("MaxHeightDistance", MaxHeightDistance.ToResoniteLinkField());
members.Add("_targetLength", _targetLength.ToResoniteLinkField());
members.Add("_visual", _visual.ToResoniteReference(context));
members.Add("_content", _content.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_visualOffset", _visualOffset.ToResoniteReference(context));
members.Add("_shelfMesh", _shelfMesh.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
}

}
}
