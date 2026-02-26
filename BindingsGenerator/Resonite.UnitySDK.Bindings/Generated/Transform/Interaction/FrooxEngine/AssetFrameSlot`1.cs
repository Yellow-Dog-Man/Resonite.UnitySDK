
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetFrameSlot<>
// Generated on: čtvrtek 26. února 2026 15:09:08
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>>> Targets = new();
public global::FrooxEngine.Slot _current { get => _current_Element.Data; set => _current_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _current_Element = new();
public UnityEngine.Vector2 _currentRatio { get => _currentRatio_Element.Data; set => _currentRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> _currentRatio_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _frameSize { get => _frameSize_Element.Data; set => _frameSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _frameSize_Element = new();
public global::FrooxEngine.BoxCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _collider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FrameSize", FrameSize_Element.ToLinkField(context));
members.Add("FrameAnimSpeed", FrameAnimSpeed_Element.ToLinkField(context));
members.Add("SnapAnimTime", SnapAnimTime_Element.ToLinkField(context));
members.Add("Targets", Targets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_current", _current_Element.ToLinkReference(context));
members.Add("_currentRatio", _currentRatio_Element.ToLinkField(context));
members.Add("_frameSize", _frameSize_Element.ToLinkReference(context));
members.Add("_collider", _collider_Element.ToLinkReference(context));
}

}
}
