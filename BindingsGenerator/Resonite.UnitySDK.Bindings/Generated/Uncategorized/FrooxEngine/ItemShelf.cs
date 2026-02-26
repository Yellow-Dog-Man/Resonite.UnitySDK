
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ItemShelf
// Generated on: čtvrtek 26. února 2026 10:04:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ItemShelf")]
public partial class ItemShelf : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock, global::FrooxEngine.IInteractionTarget

{
    public global::FrooxEngine.ItemShelf.Direction GrowDirection { get => GrowDirection_Element.Data; set => GrowDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ItemShelf.Direction>, global::FrooxEngine.ItemShelf.Direction> GrowDirection_Element = new();
public global::FrooxEngine.Grabber IgnoreGrabber { get => IgnoreGrabber_Element.Data; set => IgnoreGrabber_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> IgnoreGrabber_Element = new();
public global::System.Single MinLength { get => MinLength_Element.Data; set => MinLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinLength_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single MaxItemSize { get => MaxItemSize_Element.Data; set => MaxItemSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxItemSize_Element = new();
public global::System.Single MaxPlaneDistance { get => MaxPlaneDistance_Element.Data; set => MaxPlaneDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxPlaneDistance_Element = new();
public global::System.Single MaxHeightDistance { get => MaxHeightDistance_Element.Data; set => MaxHeightDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxHeightDistance_Element = new();
public global::System.Single _targetLength { get => _targetLength_Element.Data; set => _targetLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _targetLength_Element = new();
public global::FrooxEngine.Slot _visual { get => _visual_Element.Data; set => _visual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visual_Element = new();
public global::FrooxEngine.Slot _content { get => _content_Element.Data; set => _content_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _content_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualOffset { get => _visualOffset_Element.Data; set => _visualOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualOffset_Element = new();
public global::FrooxEngine.BevelStripeMesh _shelfMesh { get => _shelfMesh_Element.Data; set => _shelfMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _shelfMesh_Element = new();
public global::FrooxEngine.BoxCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _collider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GrowDirection", GrowDirection_Element.Data.ToResoniteLinkField());
members.Add("IgnoreGrabber", IgnoreGrabber_Element.Data.ToResoniteReference(context));
members.Add("MinLength", MinLength_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("Thickness", Thickness_Element.Data.ToResoniteLinkField());
members.Add("MaxItemSize", MaxItemSize_Element.Data.ToResoniteLinkField());
members.Add("MaxPlaneDistance", MaxPlaneDistance_Element.Data.ToResoniteLinkField());
members.Add("MaxHeightDistance", MaxHeightDistance_Element.Data.ToResoniteLinkField());
members.Add("_targetLength", _targetLength_Element.Data.ToResoniteLinkField());
members.Add("_visual", _visual_Element.Data.ToResoniteReference(context));
members.Add("_content", _content_Element.Data.ToResoniteReference(context));
members.Add("_material", _material_Element.Data.ToResoniteReference(context));
members.Add("_visualOffset", _visualOffset_Element.Data.ToResoniteReference(context));
members.Add("_shelfMesh", _shelfMesh_Element.Data.ToResoniteReference(context));
members.Add("_collider", _collider_Element.Data.ToResoniteReference(context));
}

}
}
