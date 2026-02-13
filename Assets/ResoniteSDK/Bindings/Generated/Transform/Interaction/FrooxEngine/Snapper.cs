
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Snapper
// Generated on: pátek 13. února 2026 5:52:27
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Snapper")]
public partial class Snapper : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::System.Boolean UseBoundingBoxCenter;
public global::System.Single SnapCheckRadius;
public global::System.Boolean CheckStaticColliders;
public System.Collections.Generic.List<global::FrooxEngine.SnapTarget> SnapTargetWhitelist;
public System.Collections.Generic.List<global::System.String> Keywords;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseBoundingBoxCenter", UseBoundingBoxCenter.ToResoniteLinkField());
members.Add("SnapCheckRadius", SnapCheckRadius.ToResoniteLinkField());
members.Add("CheckStaticColliders", CheckStaticColliders.ToResoniteLinkField());
members.Add("SnapTargetWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapTargetWhitelist.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Keywords", new ResoniteLink.SyncList()
{
    Elements = Keywords.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
