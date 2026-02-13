
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ItemShelf
// Generated on: pátek 13. února 2026 23:22:57
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("GrowDirection", GrowDirection.ToResoniteLinkField());
members.Add("IgnoreGrabber", new ResoniteLink.Reference() { });
members.Add("MinLength", MinLength.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("MaxItemSize", MaxItemSize.ToResoniteLinkField());
members.Add("MaxPlaneDistance", MaxPlaneDistance.ToResoniteLinkField());
members.Add("MaxHeightDistance", MaxHeightDistance.ToResoniteLinkField());
members.Add("_targetLength", _targetLength.ToResoniteLinkField());
members.Add("_visual", new ResoniteLink.Reference() { });
members.Add("_content", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_visualOffset", new ResoniteLink.Reference() { });
members.Add("_shelfMesh", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
}

}
}
