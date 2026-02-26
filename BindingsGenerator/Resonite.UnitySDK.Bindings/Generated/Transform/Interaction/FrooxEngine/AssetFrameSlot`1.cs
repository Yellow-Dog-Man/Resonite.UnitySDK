
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetFrameSlot<>
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetFrameSlot<>")]
public partial class AssetFrameSlot<A> : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock
	where A : class, global::FrooxEngine.IAsset

{
    public global::System.Single FrameSize { get => FrameSize_Element.Data; set => FrameSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FrameSize_Element = new();
public global::System.Single FrameAnimSpeed { get => FrameAnimSpeed_Element.Data; set => FrameAnimSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FrameAnimSpeed_Element = new();
public global::System.Single SnapAnimTime { get => SnapAnimTime_Element.Data; set => SnapAnimTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapAnimTime_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>> Targets = new();
public global::FrooxEngine.Slot _current { get => _current_Element.Data; set => _current_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _current_Element = new();
public UnityEngine.Vector2 _currentRatio { get => _currentRatio_Element.Data; set => _currentRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _currentRatio_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _frameSize { get => _frameSize_Element.Data; set => _frameSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _frameSize_Element = new();
public global::FrooxEngine.BoxCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _collider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FrameSize", FrameSize_Element.Data.ToResoniteLinkField());
members.Add("FrameAnimSpeed", FrameAnimSpeed_Element.Data.ToResoniteLinkField());
members.Add("SnapAnimTime", SnapAnimTime_Element.Data.ToResoniteLinkField());
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_current", _current_Element.Data.ToResoniteReference(context));
members.Add("_currentRatio", _currentRatio_Element.Data.ToResoniteLinkField());
members.Add("_frameSize", _frameSize_Element.Data.ToResoniteReference(context));
members.Add("_collider", _collider_Element.Data.ToResoniteReference(context));
}

}
}
