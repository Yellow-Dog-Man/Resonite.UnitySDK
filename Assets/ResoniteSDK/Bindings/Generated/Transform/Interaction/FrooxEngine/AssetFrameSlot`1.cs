
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AssetFrameSlot<>
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AssetFrameSlot<>")]
public partial class AssetFrameSlot<A> : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReceiver, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock
	where A : class, global::FrooxEngine.IAsset

{
    public global::System.Single FrameSize;
public global::System.Single FrameAnimSpeed;
public global::System.Single SnapAnimTime;
public System.Collections.Generic.List<global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<A>>> Targets;
public global::FrooxEngine.Slot _current;
public UnityEngine.Vector2 _currentRatio;
public global::FrooxEngine.IField<UnityEngine.Vector2> _frameSize;
public global::FrooxEngine.BoxCollider _collider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FrameSize", FrameSize.ToResoniteLinkField());
members.Add("FrameAnimSpeed", FrameAnimSpeed.ToResoniteLinkField());
members.Add("SnapAnimTime", SnapAnimTime.ToResoniteLinkField());
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_current", new ResoniteLink.Reference() { });
members.Add("_currentRatio", _currentRatio.ToResoniteLinkField());
members.Add("_frameSize", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
}

}
}
